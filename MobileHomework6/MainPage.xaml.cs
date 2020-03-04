using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileHomework6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Clock(object sender, System.EventArgs args)
        {
            var page = new ClockPage();
            await Navigation.PushAsync(page);
            
        }

        async void Classes(object sender, System.EventArgs args)
        {
            var page = new SchoolClasses();
            await Navigation.PushAsync(page);
        }

        async void Month(object sender, System.EventArgs args)
        {
            var page = new Month_and_Date();
            await Navigation.PushAsync(page);
        }
    }
}
