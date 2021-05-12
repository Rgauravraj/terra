﻿using PartsUnlimited.Resources;
using Xamarin.Forms;

namespace PartsUnlimited.Views
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //this is changed by Sachin
            //this lince was edited by Venkat 
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = ApplicationColors.MainDarkColour,
            };

            ((NavigationPage)MainPage).BarTextColor = Device.OnPlatform(ApplicationColors.MainLightColour,
                ApplicationColors.MainLightColour, ((NavigationPage)MainPage).BarTextColor);

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
