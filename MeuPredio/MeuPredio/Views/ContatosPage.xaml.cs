using MeuPredio.ViewModels.Menu.Portaria;
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
	public partial class ContatosPage : ContentPage
	{
        ContatosViewModel ViewModel => BindingContext as ContatosViewModel;
        public ContatosPage ()
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