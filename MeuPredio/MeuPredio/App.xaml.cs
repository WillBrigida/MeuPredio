using MeuPredio.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MeuPredio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LiveReload.Init();

            MainPage = new MenuPage();
        }

        protected override void OnStart()
        {
            //App.Current.MainPage.DisplayAlert("","OnStart","Ok");
        }

        protected override void OnSleep()
        {
            //App.Current.MainPage.DisplayAlert("", "OnSleep", "Ok");
        }

        protected override void OnResume()
        {
            //App.Current.MainPage.DisplayAlert("", "OnResume", "Ok");
        }
    }
}
