using System;
using System.Collections.Generic;
using System.Text;
using battery.Services.Models;

namespace battery.Services
{
    public interface IBatteryService
    {
        BatteryInfo GetBatteryInfo();
    }
}
