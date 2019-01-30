using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Propriedade

        public ObservableCollection<Classes.MenuItem> ListaMenu { get; set; }

        #endregion

        #region Commands

        public ICommand NavegacaoMenuCommand { get { return new Command<Classes.MenuItem>(OnNavigacaoMenuExecute); } }
        public ICommand SairCommand { get { return new Command(OnSairExecute); } }

        #endregion

        #region Construtor

        public MenuViewModel()
        {
            ListaMenu = new ObservableCollection<Classes.MenuItem>
            {
                new Classes.MenuItem (FontAwesome.Building, "Portaria", "#49a4aa"),
                new Classes.MenuItem (FontAwesome.Briefcase,  "Reparos / Obras", "#e1c27f"),
                new Classes.MenuItem (FontAwesome.Calculator,  "Balancetes", "#000000"),
            };

            Teste();


        }

        #endregion

        #region Métodos

        public static bool controle;
        private void Teste()
        {
            MessagingCenter.Subscribe<MsgCenter>(this, "confirmacao", message =>
            {
                controle = true;
            });
        }


        private async void OnNavigacaoMenuExecute(Classes.MenuItem menu)
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            Navigation.NavigateMenu(menu.Titulo);
            await Task.Delay(100);
            mdp.IsPresented = false; // Esconde o Menu (Master Page).

        }

        private async void OnSairExecute()
        {
            var confirmacao = await App.Current.MainPage.DisplayAlert("Alerta", "Deseja sair da aplicação:", "Sim", "Não");
            if (confirmacao == true)
            {
                var mdp = (Application.Current.MainPage as MasterDetailPage);
                mdp.IsPresented = false; // Esconde o Menu (Master Page) antes de sair.
                await Navigation.PushAsync<LoginViewModel>(true);
            }
        }

    }

    #endregion
}


