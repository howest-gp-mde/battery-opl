using battery.ViewModels;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace battery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            MainPage = new FreshNavigationContainer(mainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
