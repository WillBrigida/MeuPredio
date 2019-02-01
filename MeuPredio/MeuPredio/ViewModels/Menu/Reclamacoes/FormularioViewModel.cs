using MeuPredio.Models;
using MeuPredio.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Reclamacoes
{
    public class FormularioViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<TipoReclamacao> ListaTipo { get; set; }
        public ObservableCollection<Reclamacao> ListaReclamacao { get; set; }


        Reclamacao reclamacao;

        private string _titulo ;

        public string Titulo
        {
            get { return _titulo; }
            set { SetProperty(ref _titulo, value); }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { SetProperty(ref _descricao, value); }
        }

        private string _descricaod;

        public string Descricaod
        {
            get { return _descricaod; }
            set { SetProperty(ref _descricaod, value); }
        }

        static string tipo = "1";
        static string titulo =  "1";
        static string descricao = "";

        #endregion

        #region Commands
        public ICommand SalvarCommand { get { return new Command(OnSalvarExecute); } }

        #endregion

        #region Construtor
        public FormularioViewModel()
        {
            reclamacao = new Reclamacao();
         
            ListaTipo = new ObservableCollection<TipoReclamacao>
            {
                new TipoReclamacao (TipoReclamacao.EnumTipo.Comportamental),
                new TipoReclamacao (TipoReclamacao.EnumTipo.Convivência),
                new TipoReclamacao (TipoReclamacao.EnumTipo.Estrutural),
                new TipoReclamacao (TipoReclamacao.EnumTipo.Elevadores),
                new TipoReclamacao (TipoReclamacao.EnumTipo.Funcionários),
            };
        }

        #endregion

        #region Métodos

        private async void OnSalvarExecute(object obj)
        {
            GetDetalhes();
            await PopupNavigation.PushAsync(new DetalheFormularioPage());
        }


        private void GetDetalhes()
        {
            ListaReclamacao = new ObservableCollection<Reclamacao>
            {
                new Reclamacao()
                {
                    Descricao = this.Descricao, Titulo = this.Titulo
                }
            };
        }

        #endregion
    }
}