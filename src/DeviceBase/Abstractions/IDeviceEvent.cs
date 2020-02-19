using System;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
    public interface IDeviceEvent
    {
        Guid CommandId { get; }
        DateTime Timestamp { get; }
    }
}
