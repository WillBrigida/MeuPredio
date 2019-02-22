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
	public partial class NovoFuncionarioPage : ContentPage
	{
        private NovoFuncionarioViewModel ViewModel => BindingContext as NovoFuncionarioViewModel;
        public NovoFuncionarioPage ()
		{
			InitializeComponent();
            //this.BindingContext = new NovoFuncionarioViewMode();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.LoadAsync();
        }
    }
}