﻿using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinExpander.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            LabelName.Text = "Name: " + $"{AppInfo.Name}";

            LabelVersion.Text = "Version " + $"{AppInfo.VersionString} " +
                $"{AppInfo.BuildString}";

        }

        private async void Button_Web(object sender, EventArgs e)
        {

           await Browser.OpenAsync("https://xamarininteligente.com", BrowserLaunchMode.SystemPreferred );
        }
    }
}
