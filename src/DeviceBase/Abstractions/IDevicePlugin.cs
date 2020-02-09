using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
	public interface IDevicePlugin
	{
		public string Name { get; }
		public string Description { get; }
		public IEnumerable<IDeviceAction> DeviceActions { get; }
		public void RegisterDependencies(IServiceCollection services);
	}
}
