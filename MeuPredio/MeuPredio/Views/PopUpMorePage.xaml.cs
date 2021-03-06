﻿using MeuPredio.ViewModels.Menu.Portaria;
using Rg.Plugins.Popup.Services;
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
	public partial class PopUpMorePage 
	{
		public PopUpMorePage ()
		{
			InitializeComponent ();
            BindingContext = new PopUpMoreViewModel();
		}

        protected override bool OnBackButtonPressed() // Desativa o botão de voltar
        {
            return false;
            PopupNavigation.PopAsync();
        }
    }
}