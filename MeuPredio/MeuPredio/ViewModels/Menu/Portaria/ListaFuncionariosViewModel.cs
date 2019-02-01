using MeuPredio.Models;
using MeuPredio.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels
{
    public class ListaFuncionariosViewModel : BaseViewModel
    {
        #region Propriedade

        private ObservableCollection<Funcionarios> _listaFuncionarios;

        public ObservableCollection<Funcionarios> ListaFuncionarios
        {
            get { return _listaFuncionarios; }
            set { SetProperty(ref _listaFuncionarios, value); }
        }

        public ObservableCollection<Funcionarios> _listaFuncionáriosFiltrada { get; set; }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { SetProperty(ref _telefone, value); }
        }

        private string _funcao;

        public string Funcao
        {
            get { return _funcao; }
            set { SetProperty(ref _funcao, value); }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _imagem;

        public string Imagem
        {
            get { return _imagem; }
            set { SetProperty(ref _imagem, value); }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }


        static string nome = "";
        static string imagem = "";
        static string sobrenome = "";
        static string funcao = "";
        static string telefone = "";
        static string email = "";
        static string descricao = string.Empty;

        public enum EnumStatus
        {
            Escalado,
            Folga,
            Ferias,
        }

        public EnumStatus StatusTeste { get; set; }

        #endregion

        #region Commands

        public ICommand NavigationCommand { get { return new Command<Funcionarios>(OnNavigationExecute); } }
        public ICommand MoreCommand { get { return new Command(OnMoreExecute); } }

        #endregion

        #region Construtor

        public ListaFuncionariosViewModel()
        {
            ListaFuncionarios = new ObservableCollection<Funcionarios>();
            ListaFunc();
            TesteList();


            this.Nome = nome + " " + sobrenome;
            this.Funcao = funcao;
            this.Telefone = telefone;
            this.Email = email;
            this.Imagem = imagem;
            this.Status = GetStatus();
            this.Descricao = descricao;
        }

        #endregion

        #region Métodos

        private void ListaFunc()
        {
            IsRunning = true;

            ListaFuncionarios = new ObservableCollection<Funcionarios>()
           {
               new Funcionarios{ NomePessoa = "Robson", SobrenomePessoa = "Sobrenome",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente: Seg à Sex, 7:00 às 15:00 e Sab/Dom alternados de 7:00 as 17:00",
             FuncaoFuncionario = "Porteiro Chefe", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot1" },

                new Funcionarios{ NomePessoa = "Raimundo", SobrenomePessoa = "Sobrenome",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente: 12x36 – 19:00 às 07:00h",
             FuncaoFuncionario = "Porteiro Noturno", EmailPessoa = "marcos@hotmailmail.com", Imagem = "fot2"},

                 new Funcionarios{ NomePessoa = "Everaldo", SobrenomePessoa = "Sobrenome",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente: 12x36 – 19:00 às 07:00h",
             FuncaoFuncionario = "Porteiro Noturno", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot1"},

                  new Funcionarios{ NomePessoa = "Vitor", SobrenomePessoa = "Sobrenomeo",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente 12x36 – 07:00 às 19:00h",
             FuncaoFuncionario = "Porteiro Diurno", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot2"},

                   new Funcionarios{ NomePessoa = "Guilherme", SobrenomePessoa = "Sobrenome",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente Seg à Sex, 23:00 à 01:00 e Sab/Dom alternados de 23:00 à 01:00",
             FuncaoFuncionario = "Folguista", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot1"},

                     new Funcionarios{ NomePessoa = "Ediclaudio", SobrenomePessoa = "Sobrenome",
              TelefonePessoa = "(21) 00000 - 0000", Descricao = "Expediente Seg à Sab 07:00 às 16:00h",
             FuncaoFuncionario = "Limpeza", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot2"},

           };

            IsRunning = false;
        }

        private void OnNavigationExecute(Funcionarios funcionarios)
        {
            var mdp = (App.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            nome = funcionarios.NomePessoa;
            funcao = funcionarios.FuncaoFuncionario;
            sobrenome = funcionarios.SobrenomePessoa;
            telefone = funcionarios.TelefonePessoa;
            email = funcionarios.EmailPessoa;
            imagem = funcionarios.Imagem;
            descricao = funcionarios.Descricao;
            contador = 0;
            Init();

            navPage.PushAsync(new PerfilPage());
        }

        static int contador;
        private void Init()
        {
            if (contador == 0)
            {
                contador = 1;
                ListaFuncionariosViewModel listaFuncionariosViewModel = new ListaFuncionariosViewModel();
            }
        }

        private string GetStatus()
        {
            //this.Color = "#65B980";
            this.Status = EnumStatus.Escalado.ToString();
            return Status;
        }


        private async void OnMoreExecute()
        {
            await PopupNavigation.PushAsync(new PopUpMorePage());
        }

        public static string itemLista = "";

        private void TesteList()
        {
            var lista = ListaFuncionarios;
            foreach (var item in lista)
            {
                itemLista = item.NomePessoa[0].ToString();
            }
        }
        #endregion
    }
}
