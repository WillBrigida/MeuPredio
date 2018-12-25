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
	public partial class InformacoesPage : ContentPage
	{
		public InformacoesPage ()
		{
			InitializeComponent ();
            this.BindingContext = new InformacoesViewModel();

        }
	}
}