using MeuPredio.ViewModels;
using MeuPredio.ViewModels.Classes;
using MeuPredio.ViewModels.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PerfilPage : ContentPage
	{

        static bool controle = true;
		public PerfilPage ()
		{
			InitializeComponent ();
            
            if (controle == true)
            {
                this.BindingContext = new ListaFuncionariosViewModel();
                return;
            }
            this.BindingContext = new SindicoViewModel();
            controle = true;
        }

       

        protected override  void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<MsgCenter>(this, "confirmacao", message =>
            {
                controle = false;
            });
        }
    }
}