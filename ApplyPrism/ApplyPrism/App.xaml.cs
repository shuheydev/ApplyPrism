using System;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApplyPrismToXamarinFormsFromScratch
{
    public partial class App
    {
        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

        //protected override void OnStart()
        //{
        //    // Handle when your app starts
        //}

        //protected override void OnSleep()
        //{
        //    // Handle when your app sleeps
        //}

        //protected override void OnResume()
        //{
        //    // Handle when your app resumes
        //}

        //public App(IPlatformInitializer initializer = null) : base(initializer)
        //{

        //}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //ここではDIコンテナへの登録を記述する
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync(nameof(MainPage));
        }
    }
}
