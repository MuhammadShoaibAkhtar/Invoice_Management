using Invoice_Management_System.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invoice_Management_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Timer timer;
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = BindingClass.LoginVM;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            LoginUsername.Focus();
            fName.Focus();
        }
        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (MainCarouselView.Position == 2)
                {
                    MainCarouselView.Position = 0;
                    return;
                }
                MainCarouselView.Position += 1;
            });
        }

        private async void LoginPassword_Completed(object sender, EventArgs e)
        {
            var username = "Admin";
            var pass = "Admin@1234";
            Application.Current.MainPage = new NavigationPage(new MainPage());
            //var status = await App.Database.VerifyUser(username, pass);
            //if (status != null && status.Count > 0)
            //{
            //    var user = status.FirstOrDefault();
            //    var stats = await MethodUtil.GetDatafromAPI(user.Branch_Id);
            //    if (stats)
            //    {
            //        BindingClass.HomePageVM.UserName = user.UserName;
            //        if (user.RoleName == "Cashier")
            //        {
            //            Application.Current.MainPage = new NavigationPage(new RestrictedHomeScreen());
            //        }
            //        else
            //        {
            //            Application.Current.MainPage = new NavigationPage(new MainPage());
            //        }
            //    }
            //    else
            //    {
            //        //Could not pull data
            //    }
            //}
            //else
            //{
            //    //Not a valid user
            //}

        }

        private void LoginUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != "")
            {

            }
        }

        private void OnCreateUserTap(object sender, EventArgs e)
        {

        }
    }
    public class SliderImages
    {
        public string Image { get; set; }
    }
}