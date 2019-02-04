using MeuPredio.Models;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class PopUpOpcaoViewModel : BaseViewModel
    {
        #region Propriedade
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private string _telPessoal;

        public string TelPessoal
        {
            get { return _telPessoal; }
            set { SetProperty(ref _telPessoal, value); }
        }


        private string _textButtonWp;

        public string TextButtonWp
        {
            get { return _textButtonWp; }
            set { SetProperty(ref _textButtonWp, value); }
        }

        private string _textButtonTP;

        public string TextButtonTP
        {
            get { return _textButtonTP; }
            set { SetProperty(ref _textButtonTP, value); }
        }

        private string _textButtonTp;

        public string TextButtonTp
        {
            get { return _textButtonTp; }
            set { SetProperty(ref _textButtonTp, value); }
        }


        static string telPessoal = string.Empty;
        static string nome = string.Empty;

        #endregion

        #region Commands
        public ICommand WaCommand { get { return new Command(OnWaExecute); } }
        public ICommand LigarCommand { get { return new Command(OnLigarExecute); } }
        public ICommand LigarPortariaCommand { get { return new Command(OnLigarPortariaExecute); } }

        #endregion

        #region Construtor
        public PopUpOpcaoViewModel()
        {
            TextButtonWp = "Enviar mensagem para o Sr "+ nome;
            TextButtonTp = "Ligar para o Sr " + nome;
            TextButtonTP = "Ligar para Portaria";
        }
        #endregion

        #region Métodos


        public void InfoFuncionario(Funcionarios funcionario)
        {
            telPessoal = funcionario.TelefonePessoa;
            TelPortaria = this.TelPortaria;
            nome = funcionario.NomePessoa;
        }


        private async void OnWaExecute(object obj)
        {
            try
            {
                Chat.Open("51" + telPessoal, "Olá senhor "+nome );
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            await PopupNavigation.PopAsync();
        }

        private async void OnLigarExecute(object obj)
        {
            try
            {
                PhoneDialer.Open(telPessoal);
            }
            catch (ArgumentNullException anEx)
            {
                await App.Current.MainPage.DisplayAlert("Erro", anEx.Message, "OK");
            }
            catch (FeatureNotSupportedException ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            await PopupNavigation.PopAsync();
        }

        private async void OnLigarPortariaExecute(object obj)
        {
            try
            {
                PhoneDialer.Open(TelPortaria);
            }
            catch (ArgumentNullException anEx)
            {
                await App.Current.MainPage.DisplayAlert("Erro", anEx.Message, "OK");
            }
            catch (FeatureNotSupportedException ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }

            await PopupNavigation.PopAsync();
        }

        #endregion
    }
}
