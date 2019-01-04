using MeuPredio.ViewModels.Menu.Portaria;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AvisosPage : ContentPage
	{
        AvisosViewModel ViewModel => BindingContext as AvisosViewModel;
        public AvisosPage ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.LoadAsync();
        }
    }
}