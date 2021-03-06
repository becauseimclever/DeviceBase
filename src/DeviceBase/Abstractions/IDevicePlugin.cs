﻿using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
    public interface IDevicePlugin
    {
        public string Name { get; }
        public string Description { get; }
        public IEnumerable<IDevice> Devices { get; }
        public void RegisterDependencies(IServiceCollection services);
    }
}
