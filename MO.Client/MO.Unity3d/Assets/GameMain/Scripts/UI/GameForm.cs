﻿using GameFramework.Resource;
using MO.Protocol;
using MO.Unity3d.Data;
using MO.Unity3d.Entities;
using MO.Unity3d.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

namespace MO.Unity3d.UI
{
    public class GameForm : UIFormLogic
    {
        public void SendMsg()
        {
            var textCom = this.GetComponentInChildren<InputField>();
            if (string.IsNullOrEmpty(textCom.text))
                return;
            GameEntry.Entity.ShowEntity<SelfChatEntity>(
                GameEntry.Entity.GenerateSerialId(),
                "Assets/GameMain/Entities/SelfChatMsg.prefab",
                "DefaultEntityGroup", new MsgUserData(GameUser.Instance.UserName, textCom.text));
            GameUser.Instance.Channel.Send(PacketHelper.BuildPacket(new C2S100007() { Content = textCom.text }));
            textCom.text = "";
        }
    }
}
