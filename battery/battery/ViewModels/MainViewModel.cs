using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace battery.ViewModels
{
    public class MainViewModel: FreshBasePageModel
    {
        public ICommand GoToEssentialsPage
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<EssentialsViewModel>();
                });
            }
        } 
        public ICommand GoToPlatformPage
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<NativeViewModel>();
                });
            }
        }
    }
}
