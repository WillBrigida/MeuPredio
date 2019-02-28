using MeuPredio.ViewModels;
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
	public partial class ListaFuncionariosPage : ContentPage
	{
        ListaFuncionariosViewModel _vm;
        public ListaFuncionariosPage()
        {
            InitializeComponent();
            this.BindingContext = new ListaFuncionariosViewModel();
            //SetBindingContext();

        }


        //async void Done_Tapped(object sender, System.EventArgs e)
        //{
        //    await MainFrame.FadeTo(.5);
        //    PopupFrame.IsVisible = true;
        //    DoneAnimation.Play();
        //}

        //void All_Tapped(object sender, System.EventArgs e)
        //{
        //    foreach (var task in _vm.ListaFuncionarios.Where(t => !t.IsComplete))
        //        task.IsComplete = true;
        //}

        //async void Ok_Tapped(object sender, System.EventArgs e)
        //{
        //    await MainFrame.FadeTo(1);
        //    PopupFrame.IsVisible = false;
        //    SetBindingContext();
        //}

        //void SetBindingContext()
        //{
        //    _vm = new ListaFuncionariosViewModel();
        //    BindingContext = _vm;
        //}

    }
}