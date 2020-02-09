using System;
using System.Collections.Generic;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
    public interface IDevice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IDeviceAction> Actions { get; internal set; }

    }
}
