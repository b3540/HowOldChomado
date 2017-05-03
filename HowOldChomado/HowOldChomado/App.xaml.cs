﻿using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using HowOldChomado.Views;
using Xamarin.Forms;

namespace HowOldChomado
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            this.InitializeComponent();

            await this.NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            this.Container.RegisterTypeForNavigation<NavigationPage>();
            this.Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
