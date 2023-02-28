using Invoice_Management_System.Views;
using System;
using Windows.UI.ViewManagement;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invoice_Management_System
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            MainPage = new NavigationPage(new Splash());
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
