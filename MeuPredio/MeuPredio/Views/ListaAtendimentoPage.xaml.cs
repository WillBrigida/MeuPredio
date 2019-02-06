using MeuPredio.ViewModels.Menu.Atendimentos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaAtendimentoPage : ContentPage
	{
		public ListaAtendimentoPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ListaAtendimentoViewModel();
		}
	}
}