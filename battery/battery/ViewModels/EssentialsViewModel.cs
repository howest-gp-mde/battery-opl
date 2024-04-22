using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace battery.ViewModels
{
    public class EssentialsViewModel : FreshBasePageModel
    {
        private string powerSource;

        public string PowerSource
        {
            get { return powerSource; }
            set { powerSource = value; RaisePropertyChanged(nameof(PowerSource)); }
        }


        private int chargeLevel;

        public int ChargeLevel
        {
            get { return chargeLevel; }
            set { chargeLevel = value; RaisePropertyChanged(nameof(ChargeLevel)); }
        }


        private bool isCharging;

        public bool IsCharging
        {
            get { return isCharging; }
            set { isCharging = value; RaisePropertyChanged(nameof(IsCharging)); }
        }


        private string state;

        public string State
        {
            get { return state; }
            set { state = value; RaisePropertyChanged(nameof(State)); }
        }


        public EssentialsViewModel()
        {
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            this.ChargeLevel = (int)(Battery.ChargeLevel * 100);
        }

        public ICommand LoadCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.PowerSource = Battery.PowerSource.ToString();
                    this.ChargeLevel = (int)(Battery.ChargeLevel * 100);
                    this.State = Battery.State.ToString();
                });
            }
        }
    }
}
