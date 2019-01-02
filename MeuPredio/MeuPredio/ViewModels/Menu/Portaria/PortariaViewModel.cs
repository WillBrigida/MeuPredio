﻿using MeuPredio.ViewModels.Classes;
using MeuPredio.ViewModels.Menu.Portaria;
using MeuPredio.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels
{
    public class PortariaViewModel : BaseViewModel
    {
        #region Propriedade
        private bool _controle;

        public bool Controle
        {
            get { return _controle; }
            set { SetProperty(ref _controle, value); }
        }


        #endregion

        #region Commands

        public ICommand ListaFuncionariosCommand { get { return new Command(OnListaFuncionariosExecute); } }
        public ICommand EncomendasCommand { get { return new Command(OnEncomendasExecute); } }
        public ICommand SindicoCommand { get { return new Command(OnSindicoExecute); } }
        public ICommand RegrasCommand { get { return new Command(OnRegrasExecute); } }
        public ICommand OcorrenciasCommand { get { return new Command(OnOcorrenciasExecute); } }
        public ICommand ContatosCommand { get { return new Command(OnContatosExecute); } }

        #endregion

        #region Construtor

        #endregion

        #region Métodos

        private async void OnListaFuncionariosExecute()
        {
            await Navigation.PushAsync<ListaFuncionariosViewModel>(false);
        }


        private async void OnOcorrenciasExecute(object obj)
        {
            await Navigation.PushAsync<OcorrenciasViewModel>();
        }


        private async void OnEncomendasExecute()
        {
            await Navigation.PushAsync<EncomendasViewModel>(false);
        }

        private async void OnSindicoExecute(object obj)
        {

            MessagingCenter.Send(new MsgCenter { msg = this.Controle }, "confirmacao");

            var mdp = (App.Current.MainPage as MasterDetailPage);
            var navPae = mdp.Detail as NavigationPage;

            await navPae.PushAsync(new PerfilPage());
        }
        

        private async void OnRegrasExecute(object obj)
        {
            await Navigation.PushAsync<RegrasViewModel>(false);
        }


        private async void OnContatosExecute(object obj)
        {
            await Navigation.PushAsync<ContatosViewModel>(false);
        }

        #endregion
    }
}