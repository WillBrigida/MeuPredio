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
        private bool _login;

        public bool Login
        {
            get { return _login; }
            set { SetProperty(ref _login, value); }
        }

        private bool _senha;

        public bool Senha
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

        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new Command(OnLoginCommandExecute); } }
        #endregion

        #region Construtor
        public LoginViewModel()
        {
        }
        #endregion

        #region Métodos

        private async void OnLoginCommandExecute(object obj)
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            IsRunning = true;
            await Task.Delay(2000);


            await App.Current.MainPage.Navigation.PopModalAsync();
            IsRunning = false;

        }

        #endregion
    }
}

