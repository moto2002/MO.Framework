﻿using MO.Protocol;
using Orleans;
using System.Threading.Tasks;

namespace MO.GrainInterfaces.Network
{
    public interface IPacketRouterGrain : IGrainWithIntegerKey
    {
        //Task SetObserver(IPacketObserver observer);
        Task SendPacket(MOMsg packet);
        Task Disconnect();
    }
}
