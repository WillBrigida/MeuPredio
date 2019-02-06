using MeuPredio.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PortariaPage : ContentPage
    {

        private PortariaViewModel ViewModel => BindingContext as PortariaViewModel;
        public PortariaPage()
        {
            InitializeComponent();
            this.BindingContext = new PortariaViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();

        }

        //protected override async void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    await ViewModel.LoadAsync();
        //}

        protected override bool OnBackButtonPressed() // Desativa o botão de voltar
        {
            return true;
        }

    }
}

