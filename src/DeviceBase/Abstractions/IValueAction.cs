using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BecauseImClever.DeviceBase.Abstractions
{
    public interface IValueAction : IDeviceAction
    {
        ValueTask<object> CurrentState(Guid Id);
        ValueTask<object> SetState(Guid Id, object state);
    }
}
