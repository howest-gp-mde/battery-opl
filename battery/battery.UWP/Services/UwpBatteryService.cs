using battery.Services;
using battery.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly:Dependency(typeof(battery.UWP.Services.UwpBatteryService))]
namespace battery.UWP.Services
{
    public class UwpBatteryService : IBatteryService
    {
        public BatteryInfo GetBatteryInfo()
        {
            throw new NotImplementedException();
        }
    }
}
