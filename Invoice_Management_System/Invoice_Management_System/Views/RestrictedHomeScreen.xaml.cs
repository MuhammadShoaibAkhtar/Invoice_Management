using Invoice_Management_System.Utility;
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
    public partial class RestrictedHomeScreen : ContentPage
    {
        public RestrictedHomeScreen()
        {
            InitializeComponent();
            this.BindingContext = BindingClass.HomePageVM;
        }
    }
}