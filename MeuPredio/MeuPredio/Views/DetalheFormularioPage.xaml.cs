using MeuPredio.ViewModels.Menu.Reclamacoes;
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
	public partial class DetalheFormularioPage 
	{
		public DetalheFormularioPage ()
		{
			InitializeComponent ();
            this.BindingContext = new FormularioViewModel();
		}
	}
}