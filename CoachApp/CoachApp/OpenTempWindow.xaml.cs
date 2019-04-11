using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoachApp
{
    public partial class OpenTempWindow : ContentPage
    {
        public OpenTempWindow()
        {
            InitializeComponent();
            Task.Delay(10);
            Application.Current.MainPage = new TaskPage();
        }

        //private void InitializeComponent()
        //{
        //    return;
        //}

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await Task.Delay(5000);
        //    Application.Current.MainPage = new TaskPage();
        //    //await this.Navigation.PushAsync(new MainPage());
        //}
    }
}
