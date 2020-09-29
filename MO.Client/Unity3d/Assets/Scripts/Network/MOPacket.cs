﻿using GameFramework.Network;
using MO.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MOPacket : Packet
{
    public override int Id
    {
        get
        {
            if (Packet == null)
                Packet = new MOMsg();
            return Packet.ActionId;
        }
    }
    public MOMsg Packet { get; private set; }
    public MOPacket(MOMsg msg)
    {
        Packet = msg ?? new MOMsg();
    }
    public override void Clear()
    {
        Packet = null;
    }
}