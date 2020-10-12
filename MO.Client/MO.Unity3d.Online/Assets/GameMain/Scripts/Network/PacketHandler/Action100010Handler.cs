﻿using GameFramework.Network;
using MO.Algorithm.Enum;
using MO.Protocol;
using MO.Unity3d.Data;

namespace MO.Unity3d.Network.PacketHandler
{
    public class Action100010Handler : IPacketHandler
    {
        public int Id
        {
            get { return 100010; }
        }

        public void Handle(object sender, Packet packet)
        {
            S2C100010 rep = S2C100010.Parser.ParseFrom(((MOPacket)packet).Packet.Content);
            PlayerData player;
            foreach (var command in rep.Commands)
            {
                if (GameUser.Instance.Players.TryGetValue(command.UserId, out player))
                {
                    switch (command.CommandId)
                    {
                        case (int)CommandType.BigSkill:
                            player.ShowBigSkill();
                            break;
                        case (int)CommandType.Jump:
                            player.Jump();
                            break;
                        case (int)CommandType.SkillC:
                            player.ShowSkillC();
                            break;
                        case (int)CommandType.SkillX:
                            player.ShowSkillX();
                            break;
                        case (int)CommandType.SkillZ:
                            player.ShowSkillZ();
                            break;
                        case (int)CommandType.Transform:
                            var transform = TransformInfo.Parser.ParseFrom(command.CommandContent);
                            player.ServerX = transform.X;
                            player.ServerY = transform.Y;
                            player.ServerZ = transform.Z;
                            player.ServerRX = transform.RX;
                            player.ServerRY = transform.RY;
                            player.ServerRZ = transform.RZ;
                            break;
                    }
                }
            }
        }
    }
}
