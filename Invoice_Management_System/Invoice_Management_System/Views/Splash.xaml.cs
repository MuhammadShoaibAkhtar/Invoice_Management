using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invoice_Management_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
            await ShowSplashScreenAnimation();
            Application.Current.MainPage = new NavigationPage(new Login());
        }
        private async Task ShowSplashScreenAnimation()
        {
            await Task.Delay(0);
            //var stat = await MethodUtil.GetUsersDataFromAPI();
            //if (stat)
            //{
            //    await SplashIcon.ScaleTo(0.5, 500, Easing.CubicInOut);
            //    var animationTasks = new[]{
            //    SplashIcon.ScaleTo(100.0, 1000, Easing.CubicInOut),
            //    SplashIcon.FadeTo(0, 700, Easing.CubicInOut)
            //    };
            //    await Task.WhenAll(animationTasks);
            //}
            //else
            //{
            //    //Show Error
            //}

        }
    }
}