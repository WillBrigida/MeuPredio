﻿using MeuPredio.ViewModels.Menu.Atendimentos;
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
	public partial class AtendimentoEmAndamentoPage : ContentPage
	{
		public AtendimentoEmAndamentoPage ()
		{
			InitializeComponent ();
            this.BindingContext = new AtendimentoEmAndamentoViewModel();

        }
	}
}