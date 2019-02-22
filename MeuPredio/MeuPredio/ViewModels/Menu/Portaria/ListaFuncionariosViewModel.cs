﻿using MeuPredio.Models;
using MeuPredio.Services;
using MeuPredio.ViewModels.Menu.Portaria;
using MeuPredio.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public NovoFuncionarioViewModel novoFuncionario { get; set; }

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
        readonly PopUpOpcaoViewModel popUpOpcaoViewModel;
        private ApiService apiService;

        #endregion

        #region Commands

        public ICommand NavigationCommand { get { return new Command<Funcionarios>(OnNavigationExecute); } }
        public ICommand MoreCommand { get { return new Command(OnMoreExecute); } }
        public ICommand OpcaoCommand { get { return new Command(OnOpcaoExecute); } }
        public ICommand AddCommand { get { return new Command(OnAddExecute); } }

        #endregion

        #region Construtor

        public ListaFuncionariosViewModel()
        {
            apiService = new ApiService();
            ListaFuncionarios = new ObservableCollection<Funcionarios>();
            novoFuncionario = new NovoFuncionarioViewModel();
            popUpOpcaoViewModel = new PopUpOpcaoViewModel();
            //ListaFunc();
            //TesteList();
            LoadFuncionarios();


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

        //private void ListaFunc()
        //{
        //    IsRunning = true;

        //    ListaFuncionarios = new ObservableCollection<Funcionarios>()
        //   {
        //       new Funcionarios{ NomePessoa = "Robson", SobrenomePessoa = "Sobrenome",
        //      TelefonePessoa = "(21) 90000 - 0000", DescricaoFuncionario = "Expediente: Seg à Sex, 7:00 às 15:00 e Sab/Dom alternados de 7:00 às 17:00",
        //     FuncaoFuncionario = "Porteiro Chefe",  = "jose_silva@gmail.com", ImagemFuncionario = "fot1" },

        //        new Funcionarios{ NomePessoa = "Raimundo", SobrenomePessoa = "Sobrenome",
        //      TelefonePessoa = "(21) 90000 - 0000", Descricao = "Expediente: 12x36 – 19:00 às 07:00h",
        //     FuncaoFuncionario = "Porteiro Noturno", EmailPessoa = "marcos@hotmailmail.com", Imagem = "fot2"},

        //         new Funcionarios{ NomePessoa = "Everaldo", SobrenomePessoa = "Sobrenome",
        //      TelefonePessoa = "(21) 90000 - 0000", Descricao = "Expediente: 12x36 – 19:00 às 07:00h",
        //     FuncaoFuncionario = "Porteiro Noturno", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot1"},

        //          new Funcionarios{ NomePessoa = "Vitor", SobrenomePessoa = "Sobrenomeo",
        //      TelefonePessoa = "(21) 90000 - 0000", Descricao = "Expediente 12x36 – 07:00 às 19:00h",
        //     FuncaoFuncionario = "Porteiro Diurno", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot2"},

        //           new Funcionarios{ NomePessoa = "Guilherme", SobrenomePessoa = "Sobrenome",
        //      TelefonePessoa = "(21) 90000 - 0000", Descricao = "Expediente Seg à Sex, 23:00 à 01:00 e Sab/Dom alternados de 23:00 à 01:00",
        //     FuncaoFuncionario = "Folguista", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot1"},

        //             new Funcionarios{ NomePessoa = "Ediclaudio", SobrenomePessoa = "Sobrenome",
        //      TelefonePessoa = "(21) 90000 - 0000", Descricao = "Expediente Seg à Sab 07:00 às 16:00h",
        //     FuncaoFuncionario = "Limpeza", EmailPessoa = "jose_silva@gmail.com", Imagem = "fot2"},

        //   };
        //    IsRunning = false;
        //}

        private async void LoadFuncionarios()
        {
            this.IsRunning = true;
            var funcionarios = await apiService.Get<Funcionarios>("https://backandmeupredio2.azurewebsites.net/", " /api", "/Funcionarios");
            ConverterFuncionarios(funcionarios);
            this.IsRunning = false;
        }

        private void ConverterFuncionarios(List<Funcionarios> funcionarios)
        {
            ListaFuncionarios.Clear();
            foreach (var item in funcionarios)
            {
                ListaFuncionarios.Add(new Funcionarios
                {
                    
                    NomeFuncionario = item.NomeFuncionario,
                    SobrenomeFuncionario = item.SobrenomeFuncionario,
                    FuncaoFuncionario = item.FuncaoFuncionario,
                    DescricaoFuncionario = item.DescricaoFuncionario,
                    StatusFuncionario = item.StatusFuncionario,
                    TelefoneFuncionario = item.TelefoneFuncionario,
                    ObservaçãoFuncionario = item.ObservaçãoFuncionario,
                    ImagemFuncionario = item.ImagemFuncionario,
                   
                });
            }
        }

        private void OnNavigationExecute(Funcionarios funcionarios)
        {
            var mdp = (App.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            nome = funcionarios.NomeFuncionario;
            funcao = funcionarios.FuncaoFuncionario;
            sobrenome = funcionarios.SobrenomeFuncionario;
            telefone = funcionarios.TelefoneFuncionario;
            imagem = funcionarios.ImagemFullPath;
            descricao = funcionarios.DescricaoFuncionario;
            contador = 0;
            Init();
            popUpOpcaoViewModel.InfoFuncionario(funcionarios);

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
                itemLista = item.NomeFuncionario[0].ToString();
            }
        }


        private async void OnOpcaoExecute(object obj)
        {
            await PopupNavigation.PushAsync(new PopUpOpcaoPage());
        }



        private async void OnAddExecute(object obj)
        {
            await Navigation.PushAsync<NovoFuncionarioViewModel>(false);
        }

        #endregion
    }
}
