
namespace BecauseImClever.HomeAutomation.DeviceBase
{
	using Abstractions;
	using System;
	using System.Collections.Generic;

	public abstract class Device
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<IDeviceAction> Actions { get; internal set; }
	}
}