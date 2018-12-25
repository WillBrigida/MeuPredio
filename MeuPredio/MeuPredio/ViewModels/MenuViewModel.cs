using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Menu = MeuPredio.ViewModels.Classes.Menu;

namespace MeuPredio.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Propriedade

        public ObservableCollection<Menu> ListaMenu { get; set; }
        #endregion

        #region Commands

        public ICommand NavigationCommand { get { return new Command<Menu>(OnNavigationExecute); } }
        public ICommand SairCommand { get { return new Command(OnSairExecute); } }

        #endregion


        #region Construtor
        public MenuViewModel()
        {
            ListaMenu = new ObservableCollection<Menu>
            {
                new Menu (FontAwesome.Building, "Portaria", "Red"),
                new Menu (FontAwesome.Exclamation, "Reclamações", "Blue"),
                new Menu (FontAwesome.Info, "Informações", "Gray"),
                new Menu (FontAwesome.Briefcase,  "Atendimentos", "Green"),
                new Menu (FontAwesome.Barcode,  "Scanner", "#819D97"),
            };
        }
        #endregion

        #region Métodos

        private void OnNavigationExecute(Menu menu)
        {
            var titulo = menu.Titulo;

            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;

            // Hide the Master page
            mdp.IsPresented = false;

            switch (titulo)
            {
                case "Portaria":
                    mdp.Detail = new NavigationPage(new MainPage());
                    break;
                    //case "Reclamações":
                    //    mdp.Detail = new NavigationPage(new ReclamacaoTabbedPage());
                    //    break;
                    //case "Informações":
                    //    mdp.Detail = new NavigationPage(new InformacoesPage());
                    //    break;
                    //case "Atendimentos":
                    //    mdp.Detail = new NavigationPage(new AtendimentosPage());
                    //    break;
                    //case "Scanner":
                    //    mdp.Detail = new NavigationPage(new ScannerPage());
                    //    break;
                    //case "Login":
                    //    mdp.Detail = new NavigationPage(new LoginPage());
                    //    break;
            }

        }


        private void OnSairExecute()
        {
            App.Current.MainPage.DisplayAlert("", "Botão sair clicado", "ok");
        }


    }


    #endregion
}

