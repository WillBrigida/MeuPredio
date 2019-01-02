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
    public partial class RegrasPage : ContentPage
    {
        RegrasViewModel ViewModel => BindingContext as RegrasViewModel;
        public RegrasPage()
        {
            InitializeComponent();
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }
    }
}