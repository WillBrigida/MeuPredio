using MeuPredio.ViewModels;
using MeuPredio.ViewModels.Classes;
using MeuPredio.ViewModels.Menu;
using MeuPredio.ViewModels.Menu.Portaria;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilPage : ContentPage
    {

        static bool controle;
        public PerfilPage()
        {
            InitializeComponent();
            Teste();
        }


        private void Teste()
        {

            if (controle == false)
            {
                this.BindingContext = new ListaFuncionariosViewModel();
                //this.BindingContext = new SindicoViewModel();

            }
            else
            {
                this.BindingContext = new SindicoViewModel();
                controle = false;
            }
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<MsgCenter>(this, "confirmacao", message =>
            {
                controle = true;
            });


        }
    }
}