using MeuPredio.Helpers;
using MeuPredio.ViewModels;
using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private async void GoLogin()
        {
            _loginHelper.VerificarLogin();
            //    if (status == false)
            await Detail.Navigation.PushModalAsync(new LoginPage());
        }
    }
}