﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MO.Model.Entitys
{
    public class ServerConfig : BaseEntity
    {
        [MaxLength(2)]
        public int ServerLevel { get; set; }

        [MaxLength(20)]
        public string LoginIP { get; set; }

        [MaxLength(6)]
        public ushort LoginPort { get; set; }

        [MaxLength(20)]
        public string ApiIP { get; set; }

        [MaxLength(6)]
        public ushort ApiPort { get; set; }

        [MaxLength(20)]
        public string GateIP { get; set; }

        [MaxLength(6)]
        public ushort GatePort { get; set; }
    }
}
