using System;
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
    }
}
