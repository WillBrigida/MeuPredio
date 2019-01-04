using MeuPredio.Models;
using MeuPredio.Views;
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
            set {SetProperty(ref _nome, value); }
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


        static string nome = "";
        static string imagem = "";
        static string sobrenome = "";
        static string funcao = "";
        static string telefone = "";
        static string email = "";

        #endregion

        #region Commands

        public ICommand NavigationCommand { get { return new Command<Funcionarios>(OnNavigationExecute); } }

        #endregion

        #region Construtor

        public ListaFuncionariosViewModel()
        {
            ListaFuncionarios = new ObservableCollection<Funcionarios>();
            ListaFunc();


            this.Nome = nome + " " + sobrenome;
            this.Funcao = funcao;
            this.Telefone = telefone;
            this.Email = email;
            this.Imagem = imagem;
        }

        #endregion

        #region Métodos

        private void ListaFunc()
        {
            ListaFuncionarios = new ObservableCollection<Funcionarios>()
           {
               new Funcionarios{ NomePessoa = "José", SobrenomePessoa = "da Silva Bertoldo",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Porteiro", EmailPessoa = "jose_silva@gmail.com", Imagem = "port1"},
                new Funcionarios{ NomePessoa = "Marcos", SobrenomePessoa = "Ferraz",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Zelador", EmailPessoa = "jose_silva@gmail.com", Imagem = "port2"},
                 new Funcionarios{ NomePessoa = "Fernando", SobrenomePessoa = "da Silva Bertoldo",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Servente Geral", EmailPessoa = "jose_silva@gmail.com", Imagem = "port4"},
                  new Funcionarios{ NomePessoa = "Claudio", SobrenomePessoa = "da Silva Bertoldo",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Porteiro Chefe", EmailPessoa = "jose_silva@gmail.com", Imagem = "port1"},
                   new Funcionarios{ NomePessoa = "Antonio", SobrenomePessoa = "de Jesus",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Plantonista", EmailPessoa = "jose_silva@gmail.com", Imagem = "port2"},
                    new Funcionarios{ NomePessoa = "Fátima", SobrenomePessoa = "da Silva Bertoldo",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Porteiro", EmailPessoa = "jose_silva@gmail.com", Imagem = "port3"},
                     new Funcionarios{ NomePessoa = "Renato", SobrenomePessoa = "da Silva Bertoldo",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Porteiro", EmailPessoa = "jose_silva@gmail.com", Imagem = "port4"},
                     new Funcionarios{ NomePessoa = "Wander", SobrenomePessoa = "Conceição",
              TelefonePessoa = "(21)98115-5225", Descricao = "Funcionário responsável por...",
             FuncaoFuncionario = "Sindico", EmailPessoa = "wander@gmail.com", Imagem = "port1"},

           };
        
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
            contador = 0;
            Init();

            navPage.PushAsync(new PerfilPage());
        }

        static int contador;
        private void Init()
        {
            if (contador == 0 )
            {
                contador = 1;
                ListaFuncionariosViewModel listaFuncionariosViewModel = new ListaFuncionariosViewModel();
            }
        }

        #endregion
    }
}
 