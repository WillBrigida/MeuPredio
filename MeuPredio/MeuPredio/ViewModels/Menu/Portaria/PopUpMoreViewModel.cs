using MeuPredio.ViewModels.Classes;
using MeuPredio.ViewModels.Menu.Reclamacoes;
using MeuPredio.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class PopUpMoreViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<MaisDetalhes> ListaMore { get; set; }
        public enum Enum {Reclamação, Elogio }
        public Enum Lista { get; set; }
        #endregion

        #region Commands
        public ICommand NavegacaoMenuCommand { get { return new Command<MaisDetalhes>(OnNavigationExecute); } }
        

        #endregion

        #region Construtor
        public PopUpMoreViewModel()
        {
            ListaMore = new ObservableCollection<MaisDetalhes>
           {
               new MaisDetalhes(MaisDetalhes.Enum.Elogio, FontAwesome.ThumbsUp), 
               new MaisDetalhes(MaisDetalhes.Enum.Reclamação, FontAwesome.ThumbsDown),
           };
        }
        #endregion

        #region Métodos

        private async void OnNavigationExecute(MaisDetalhes obj)
        {
            await PopupNavigation.PopAsync();
            await Navigation.PushAsync<FormularioViewModel>(true);
        }
        #endregion
    }
}
