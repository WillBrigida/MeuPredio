using MeuPredio.Helpers;
using MeuPredio.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        LoginHelper _loginHelper;
        public MenuPage()
        {

            _loginHelper = new LoginHelper();
            InitializeComponent();
            this.BindingContext = new MenuViewModel();
            Detail = new NavigationPage(new PortariaPage()); // Diferente do costume, a navegação é setada aqui e não no App.xaml.cs
            GoLogin();
        }

        static bool controle;
        private async void GoLogin()
        {
            if (controle == false)
            {
                await Detail.Navigation.PushModalAsync(new LoginPage());
                controle = true;
            }
            // _loginHelper.VerificarLogin();
            //    if (status == false)
        }
    }
}