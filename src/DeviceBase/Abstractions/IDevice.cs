using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
    public interface IDevice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IDeviceAction> Actions { get; internal set; }
        public ValueTask Invoke(string TopicPath, string Payload);

    }
}
