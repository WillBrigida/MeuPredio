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
	public partial class OcorrenciasPage : ContentPage
	{
        OcorrenciasViewModel ViewModel => BindingContext as OcorrenciasViewModel;
        public OcorrenciasPage ()
		{
			InitializeComponent ();
            //BindingContext = new OcorrenciasViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }
    }
}