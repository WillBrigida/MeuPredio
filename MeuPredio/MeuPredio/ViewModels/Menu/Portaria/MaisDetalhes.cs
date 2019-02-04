using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class MaisDetalhes
    {
        public enum Enum { Reclamação, Elogio , Mensagem , Ligação };
        public Enum ListOpcoes { get; set; }
        public string Icone { get; set; }

        public MaisDetalhes(Enum lista, string icone)
        {
            this.ListOpcoes = lista;
            this.Icone = icone;
        }
        
    }
}
