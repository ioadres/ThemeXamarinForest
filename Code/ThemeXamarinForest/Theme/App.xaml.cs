﻿using Prism.Unity;
using Theme.ViewModels;
using Theme.Views;
using Xamarin.Forms;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Theme.Views.Templates;
using System;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Theme
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MasterPage/BaseNavigationPage/IconsDashboardPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MasterPage, MasterPageViewModel>();
            Container.RegisterTypeForNavigation<MenuPage, MenuPageViewModel>();
            Container.RegisterTypeForNavigation<BaseNavigationPage, BaseNavigationPageViewModel>();
            Container.RegisterTypeForNavigation<HomePage, HomePageViewModel>();
            Container.RegisterTypeForNavigation<IconsDashboardPage, IconsDashboardPageViewModel>();
        }
    }
}
