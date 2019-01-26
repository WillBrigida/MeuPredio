using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class PopUpMoreViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<More> ListaMore { get; set; }
        public enum Enum {Reclamação, Elogio }
        public Enum Lista { get; set; }
        #endregion

        #region Commands

        #endregion

        #region Construtor
        public PopUpMoreViewModel()
        {
            ListaMore = new ObservableCollection<More>()
           {
               new More(More.Enum.Elogios),
               new More(More.Enum.Reclamações),
           };
        }
        #endregion

        #region Métodos

        #endregion
    }
}
