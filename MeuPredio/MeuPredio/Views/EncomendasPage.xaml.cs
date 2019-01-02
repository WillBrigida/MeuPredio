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
	public partial class EncomendasPage : ContentPage
	{
        EncomendasViewModel ViewModel => BindingContext as EncomendasViewModel;
        public EncomendasPage ()
		{
			InitializeComponent ();
            //this.BindingContext = new EncomendasViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }
    }
}