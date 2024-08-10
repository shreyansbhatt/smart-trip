﻿using smart_trip.Services;
using smart_trip.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace smart_trip
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.RegisterSingleton(new ConfigurationService());
            MainPage = new SignUpPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
