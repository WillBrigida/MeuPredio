using MeuPredio.Helpers;
using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Propriedade
        private string _login;

        public string Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set { SetProperty(ref _senha, value); }
        }

        private bool _lembrarSenha;

        public bool LembrarSenha
        {
            get { return _lembrarSenha; }
            set { SetProperty(ref _lembrarSenha, value); }
        }

        readonly LoginHelper _loginHelper;
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new Command(OnLoginCommandExecute); } }
        #endregion

        #region Construtor
        public LoginViewModel()
        {
            _loginHelper = new LoginHelper();
        }
        #endregion

        #region Métodos
        private async void OnLoginCommandExecute(object obj)
        {
            IsRunning = true;

            var validacao = _loginHelper.SalvarLoginSenha(Login, Senha);
            if (validacao == false)
            {
                await App.Current.MainPage.DisplayAlert("","Senha incorreta", "OK");
                IsRunning = false;
                return;
            }

           

            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            await Task.Delay(2000);
            await App.Current.MainPage.Navigation.PopModalAsync();
            IsRunning = false;

        }

        #endregion
    }
}

