using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoachApp
{
    public partial class TimePage : ContentPage
    {
        public TimePage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing() 
        {
            base.OnAppearing();
            Task.Delay(1000);
            //Sleep(4000);
            Application.Current.MainPage = new MainPage();
        }
        public static async Task Sleep(int ms)
        {
            await Task.Delay(ms);
        }

    }
}
