using battery.Services;
using battery.Services.Models;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace battery.ViewModels
{
    public class NativeViewModel: FreshBasePageModel
    {

        private string state;

        public string State
        {
            get { return state; }
            set { state = value; RaisePropertyChanged(nameof(State)) }
        }

        private double mWHour;

        public double MWHour
        {
            get { return mWHour; }
            set { mWHour = value;  RaisePropertyChanged(nameof(MWHour)); }
        }


        public NativeViewModel()
        {

        }
        public ICommand LoadCommand
        {
            get
            {
                return new Command(() =>
                {
                    var service = DependencyService.Resolve<IBatteryService>();
                    BatteryInfo info = service.GetBatteryInfo();

                    State = info.State;
                    MWHour = info.MWHour;
                });
            }
        }
    }
}
