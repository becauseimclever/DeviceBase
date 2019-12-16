using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BecauseImClever.DeviceBase.Abstractions
{
    public interface IBooleanAction : IDeviceAction
    {
        ValueTask<bool> CurrentState(Guid Id);
        ValueTask<bool> SetState(Guid Id, bool state);
    }
}
