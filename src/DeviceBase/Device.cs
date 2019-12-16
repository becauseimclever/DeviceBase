using BecauseImClever.DeviceBase.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BecauseImClever.DeviceBase
{
    public abstract class Device
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IDeviceAction> Actions { get; internal set; }

    }
}
