using MeuPredio.Models;
using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Atendimentos
{
    public class ListaAtendimentoViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<Atendimento> ListaAtendimento { get; set; }
        readonly DetalheAtendimentoViewModel detalheAtendimentoViewModel;
        public enum EnumStatus { Aberto, Fechado }
        public EnumStatus Status { get; set; }
        #endregion

        #region Commands
        public ICommand NavigationCommand { get { return new Command<Atendimento>(OnNavigationExecute); } }
        #endregion

        #region Construtor
        public ListaAtendimentoViewModel()
        {
            detalheAtendimentoViewModel = new DetalheAtendimentoViewModel();

            ListaAtendimento = new ObservableCollection<Atendimento>(ListaAtend());
        }
        #endregion

        #region Métodos
        private void OnNavigationExecute(Atendimento atendimento)
        {
            detalheAtendimentoViewModel.SetDetalhe(atendimento);
        }

        private List<Atendimento> ListaAtend()
        {

            ListaAtendimento = new ObservableCollection<Atendimento>()
           {
               new Atendimento{Status = EnumStatus.Aberto.ToString(), Icone = FontAwesome.CheckCircle, Descricao = "Pintura da Fachada", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Aberto.ToString(), Icone = FontAwesome.CheckCircle, Descricao = "Reforma Portaria", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Aberto.ToString(), Icone = FontAwesome.CheckCircle, Descricao = "Reforma Elevadores", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Aberto.ToString(), Icone = FontAwesome.CheckCircle, Descricao = "Obra Estrutura", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Fechado.ToString(), Icone = FontAwesome.ExclamationTriangle, Descricao = "Pintura da Fachada", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Fechado.ToString(), Icone = FontAwesome.ExclamationTriangle, Descricao = "Reforma Portaria", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Fechado.ToString(), Icone = FontAwesome.ExclamationTriangle, Descricao = "Reforma Elevadores", Data = new DateTime(2019, 02, 05)},
               new Atendimento{Status = EnumStatus.Fechado.ToString(), Icone = FontAwesome.ExclamationTriangle, Descricao = "Obra Estrutura", Data = new DateTime(2019, 02, 05)},
           };

            return ListaAtendimento.Where(l => l.Status == "Aberto").ToList();
        }

        

        #endregion
    }
}
