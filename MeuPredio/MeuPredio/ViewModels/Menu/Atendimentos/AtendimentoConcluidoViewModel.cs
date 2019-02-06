using MeuPredio.Models;
using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Atendimentos
{
    public class AtendimentoConcluidoViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<Atendimento> ListaAtendimento { get; set; }
        readonly DetalheAtendimentoViewModel detalheAtendimentoViewModel;
        #endregion

        #region Commands
        
        public ICommand NavigationCommand { get { return new Command<Atendimento>(OnNavigationExecute);}}

        #endregion

        #region Construtor
        public AtendimentoConcluidoViewModel()
        {
            detalheAtendimentoViewModel = new DetalheAtendimentoViewModel();

            ListaAtendimento = new ObservableCollection<Atendimento>();
            ListaAtend();
        }
        #endregion

        #region Métodos
        private void ListaAtend()
        {
            //var dat = DateTime.DaysInMonth(10, 2019);
            ListaAtendimento = new ObservableCollection<Atendimento>()
           {
               new Atendimento{Icone = FontAwesome.CheckCircle, Descricao = "Pintura da Fachada", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Icone = FontAwesome.CheckCircle, Descricao = "Reforma Portaria", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Icone = FontAwesome.CheckCircle, Descricao = "Reforma Elevadores", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Icone = FontAwesome.CheckCircle, Descricao = "Obra Estrutura", Data = new DateTime(2019, 02, 05)},
           };
        }

        private void OnNavigationExecute(Atendimento atendimento)
        {
            detalheAtendimentoViewModel.SetDetalhe(atendimento);
        }
        #endregion
    }
}
