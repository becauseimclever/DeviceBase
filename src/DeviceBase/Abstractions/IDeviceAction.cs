using System.Threading.Tasks;

namespace BecauseImClever.HomeAutomation.DeviceBase.Abstractions
{
	public interface IDeviceAction
	{
		public void Invoke();
	}
	public interface IDeviceAction<T> : IDeviceAction
	{
		public Task<T> GetValueAsync();
		public T GetValue();

		public Task<bool> SetValueAsync(T value);
		public bool SetValue(T value);
		public void Invoke(T value);

	}
}
