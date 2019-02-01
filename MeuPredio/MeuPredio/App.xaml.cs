using MeuPredio.Views;
using Realms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MeuPredio
{
    public partial class App : Application
    {

        public App()
        {
            RealmConfiguration.DefaultConfiguration.SchemaVersion = 4;
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
