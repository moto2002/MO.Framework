﻿using MO.Protocol;
using MO.Unity3d.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MO.Unity3d.Data
{
    public class PlayerData
    {
        public Queue<CommandInfo> SendCommands { get; }
        public Queue<CommandInfo> RecvCommands { get; }
        public PlayerData()
        {
            SendCommands = new Queue<CommandInfo>();
            RecvCommands = new Queue<CommandInfo>();
        }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float RX { get; set; }
        public float RY { get; set; }
        public float RZ { get; set; }
        public int EntityId { get { return (int)UserId * 100 + 1; } }
        public int SkillCEntityId { get { return (int)UserId * 100 + 5; } }
        public int SkillXEntityId { get { return (int)UserId * 100 + 6; } }
        public int SkillZEntityId { get { return (int)UserId * 100 + 7; } }
        public int SkillBigEntityId { get { return (int)UserId * 100 + 8; } }
        public byte JumpState { get; set; }

        private void ShowSkill(int entityId, float distance)
        {
            if (GameEntry.Entity.HasEntity(entityId))
                return;

            var skillData = new SkillData();
            skillData.PlayerData = this;
            skillData.Distance = distance;
            GameEntry.Entity.ShowEntity<SkillEntity>(entityId,
                "Assets/GameMain/Entities/Skill.prefab", "DefaultEntityGroup", skillData);
        }

        public void Jump()
        {
            JumpState = 1;
        }

        public void ShowSkillC()
        {
            ShowSkill(SkillCEntityId, 9);
        }

        public void ShowSkillX()
        {
            ShowSkill(SkillXEntityId, 6);
        }

        public void ShowSkillZ()
        {
            ShowSkill(SkillZEntityId, 3);
        }

        public void ShowBigSkill()
        {
            if (GameEntry.Entity.HasEntity(SkillBigEntityId))
                return;

            var skillData = new SkillData();
            skillData.PlayerData = this;
            GameEntry.Entity.ShowEntity<BigSkillEntity>(SkillBigEntityId,
                "Assets/GameMain/Entities/BigSkill.prefab", "DefaultEntityGroup", skillData);
        }
    }
}
