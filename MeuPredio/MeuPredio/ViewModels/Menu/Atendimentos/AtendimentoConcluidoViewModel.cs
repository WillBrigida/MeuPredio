using MeuPredio.Models;
using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MeuPredio.ViewModels.Menu.Atendimentos
{
    public class AtendimentoConcluidoViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<Atendimento> ListaAtendimento { get; set; }
        #endregion

        #region Commands

        #endregion

        #region Construtor
        public AtendimentoConcluidoViewModel()
        {
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
        #endregion
    }
}
