using MeuPredio.ViewModels;
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
        static int contador = 0;
		public MenuPage ()
		{
			InitializeComponent ();
            this.BindingContext = new MenuViewModel();

            Detail = new NavigationPage(new PortariaPage()); // Diferente do costume, a navegação é setada aqui e não no App.xaml.cs
            GoLogin();
        }

        private void GoLogin()
        {

            if (contador == 0)
            {
                Detail.Navigation.PushModalAsync(new LoginPage());
                contador += 1;
            }
        }
    }
}