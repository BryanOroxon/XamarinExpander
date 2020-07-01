using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinExpander.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void Button_Sesion(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SesionPage());
        }

        private async void Button_DayList(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CustomNavigationPage(new DayListView()));
        }

        private async void Button_Calendar(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CalendarPage());
        }

        private async void Button_About(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Button_NewSesion(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NewSesionPage());
        }
    }
}
