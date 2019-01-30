using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Reclamacoes
{
    public class ListaReclamacoesViewModel : BaseViewModel
    {
        #region Propriedade

        #endregion

        #region Commands
        public ICommand NovaReclamacaoCommand { get { return new Command(OnNovaReclamacaoExecute); } }

        #endregion

        #region Construtor

        #endregion

        #region Métodos

        private async void OnNovaReclamacaoExecute(object obj)
        {
            await Navigation.PushAsync<FormularioViewModel>(true);
        }
        #endregion
    }
}
