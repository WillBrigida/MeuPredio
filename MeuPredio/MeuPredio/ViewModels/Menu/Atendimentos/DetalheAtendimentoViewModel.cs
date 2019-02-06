using MeuPredio.Models;
using MeuPredio.ViewModels;
using MeuPredio.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MeuPredio.ViewModels
{
    public class DetalheAtendimentoViewModel : BaseViewModel
    {
        #region Propriedade
        private string _icon;

        public string Icon
        {
            get { return _icon; }
            set { SetProperty(ref _icon, value); }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }

        static string icon = string.Empty;
        static string descricao = string.Empty;

        #endregion

        #region Commands

        #endregion

        #region Construtor
        public DetalheAtendimentoViewModel()
        {
            this.Icon = icon;
            this.Descricao = descricao;
        }
        #endregion

        #region Métodos
        public async void SetDetalhe(Atendimento atendimento)
        {
            descricao = atendimento.Descricao;
            icon = atendimento.Icone;
            //var mdp = (App.Current.MainPage as MasterDetailPage);
            //var navPage = mdp.Detail as NavigationPage;

            //navPage.PushAsync(new DetalheAtendimentoPage());
            await App.Current.MainPage.Navigation.PushModalAsync(new DetalheAtendimentoPage());
           
        }
        #endregion
    }
}
