using Invoice_Management_System.Utility;
using Invoice_Management_System.Views;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Invoice_Management_System
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = BindingClass.HomePageVM;
            DisplayCharts();
        }
        public void DisplayCharts()
        {
            var entries = new[]
            {
                new ChartEntry(400)
                {
                    //Label = "Alan Bain",
                    //ValueLabel="121",
                    Color = SKColor.Parse("#2c3e50")
                },
                new ChartEntry(500)
                {
                    //Label = "Brian Levine",
                    //ValueLabel="231",
                    Color = SKColor.Parse("#77d065")
                },
                new ChartEntry(700)
                {
                    //Label = "Jehangir Khan",
                    //ValueLabel="200",
                    Color = SKColor.Parse("#b455b6")
                },
                 new ChartEntry(900)
                {
                    //Label = "Alex Filatov",
                    //ValueLabel="141",
                    Color = SKColor.Parse("#FFE30E")
                },

            };
            var chart = new BarChart() { Entries = entries };
            var chart1 = new LineChart() { Entries = entries };
            var chart2 = new DonutChart() { Entries = entries };
            var chart3 = new PointChart() { Entries = entries };
            var chart4 = new RadialGaugeChart() { Entries = entries };
            var chart5 = new RadarChart() { Entries = entries };
            this.chartView4.Chart = chart2;
        }

        private async void Login_Page(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}
