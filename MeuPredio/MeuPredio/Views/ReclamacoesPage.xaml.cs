using MeuPredio.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReclamacoesPage : TabbedPage
    {
        ReclamacoesViewModel ViewModel => BindingContext as ReclamacoesViewModel;

        public ReclamacoesPage ()
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