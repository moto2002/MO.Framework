﻿using MO.GrainInterfaces.User;
using Orleans;
using ProtoMessage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MO.GrainInterfaces.Game
{
    public interface IHouseGroup : IGrainWithIntegerKey
    {
        Task AddUser(IUser user);
        Task RemoveUser(IUser user);
        Task HouseGroupNotify(MOMsg msg);
    }
}
