﻿using DotRas.Devices;
using DotRas.Internal.Abstractions.Factories;

namespace DotRas.Internal.Composition.Factories.Devices
{
    internal class VpnDeviceFactory : IDeviceFactory
    {
        public RasDevice Create(string name)
        {
            return new Vpn(name);
        }
    }
}