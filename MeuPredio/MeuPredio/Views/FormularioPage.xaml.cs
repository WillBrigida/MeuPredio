using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPredio.ViewModels;
using MeuPredio.ViewModels.Menu.Reclamacoes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormularioPage : ContentPage
	{
        private FormularioViewModel ViewModel => BindingContext as FormularioViewModel;

        public FormularioPage ()
		{

            InitializeComponent ();
            //this.BindingContext = new FormularioViewModel();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.LoadAsync();
        }
    }
}