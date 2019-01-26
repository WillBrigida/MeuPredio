using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class More
    {
        public enum Enum { Reclamações, Elogios };
        public Enum ListOpcoes { get; set; }

        public More(Enum lista)
        {
            this.ListOpcoes = lista;
        }
        
    }
}
