﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MO.Algorithm.Enum
{
    /// <summary>
    /// 手机类型
    /// </summary>
    public enum DeviceType
    {
        Normal = 0,
        iPod = 1,
        iPad = 2,
        /// <summary>
        /// 破解版iPhone和iPad
        /// </summary>
        iPhone = 3,
        /// <summary>
        /// 非破解版iPhone
        /// </summary>
        Phone_AppStore = 4,
        Android = 5,
        Mac = 6,
        WindowsPhone7 = 7,
        Windows = 8,
        Unknow = 9
    }
}
