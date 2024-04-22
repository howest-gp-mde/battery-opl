using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using battery.Services;
using battery.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(battery.Droid.Services.AndroidBatteryService))]
namespace battery.Droid.Services
{
    public class AndroidBatteryService : IBatteryService
    {
        public BatteryInfo GetBatteryInfo()
        {
            throw new NotImplementedException();
        }
    }
}