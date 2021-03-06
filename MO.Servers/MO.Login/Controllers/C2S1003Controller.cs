﻿using Google.Protobuf;
using Microsoft.Extensions.Logging;
using MO.Algorithm.Enum;
using MO.Common.Security;
using MO.GrainInterfaces.User;
using MO.Model.Context;
using MO.Model.Entitys;
using MO.Protocol;
using Orleans;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MO.Login.Controllers
{
    /// <summary>
    /// 游客登录
    /// </summary>
    public class C2S1003Controller : BaseController
    {
        private readonly ILogger _logger;
        private readonly MODataContext _dataContext;
        private readonly MORecordContext _recordContext;
        private readonly IClusterClient _client;
        public C2S1003Controller(
            IClusterClient client,
            MODataContext dataContext,
            MORecordContext recordContext,
            ILogger<C2S1003Controller> logger)
        {
            _client = client;
            _dataContext = dataContext;
            _recordContext = recordContext;
            _logger = logger;
        }

        public override Task<string> GetMessage()
        {
            var req1003 = C2S1003.Parser.ParseFrom(ByteString.FromBase64(data));

            var user = _dataContext.GameUsers.Where(m => m.DeviceId == req1003.DeviceId).FirstOrDefault();
            long userId = 0;
            if (user == null || user.UserId == 0)
            {
                //注册账号
                var userIdFactory = _client.GetGrain<IUserIdFactoryGrain>(default(Int64));
                userId = userIdFactory.GetNewUserId().Result;
                user = new GameUser();
                user.UserId = userId;
                user.NickName = "游客001";
                user.HeadIcon = "1";
                user.DeviceId = req1003.DeviceId;
                _dataContext.Add(user);
                _dataContext.SaveChanges();
            }
            else
            {
                userId = user.UserId;
            }

            //将玩家踢出游戏
            var userGrain = _client.GetGrain<IUserGrain>(userId);
            userGrain.SetNickName(req1003.DeviceId);
            userGrain.Kick().Wait();
            var token = CryptoHelper.MD5_Encrypt($"{userId}{Guid.NewGuid()}{DateTime.UtcNow.Ticks}");
            var tokenGtain = _client.GetGrain<ITokenGrain>(userId);
            tokenGtain.SetToken(token, HttpContext.Connection.RemoteIpAddress.ToString()).Wait();

            _recordContext.Add(new LoginRecord()
            {
                UserId = userId,
                LoginType = LoginType.None,
                LoginIP = HttpContext.Connection.RemoteIpAddress.ToString(),
                LoginDevice = req1003.DeviceId
            });
            _recordContext.SaveChangesAsync();

            var serverconfig = _dataContext.ServerConfigs.Where(m => m.ServerLevel == 0).FirstOrDefault();
            if (serverconfig == null)
            {
                return Task.FromResult(new MOMsgResult() { ErrorCode = (int)MOErrorType.Shown, ErrorInfo = "服务器不存在" }.ToByteString().ToBase64());
            }

            var message = new S2C1003();
            message.Token = token;
            message.UserId = userId;
            message.UserName = req1003.DeviceId;
            message.LoginIP = serverconfig.LoginIP;
            message.LoginPort = serverconfig.LoginPort;
            message.ApiIP = serverconfig.ApiIP;
            message.ApiPort = serverconfig.ApiPort;
            message.GateIP = serverconfig.GateIP;
            message.GatePort = serverconfig.GatePort;

            return Task.FromResult(new MOMsgResult() { Content = message.ToByteString() }.ToByteString().ToBase64());
        }
    }
}
