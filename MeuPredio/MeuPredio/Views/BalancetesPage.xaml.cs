﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BalancetesPage : ContentPage
	{
		public BalancetesPage ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed() // Desativa o botão de voltar
        {
            return true;
        }
    }
}