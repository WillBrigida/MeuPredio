using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.ViewModels.Classes
{
    public class Menu
    {
        public string Icone { get; set; }
        public string Titulo { get; set; }
        public string Cor { get; set; }

        public Menu(string icone, string titulo, string cor )
        {
            this.Icone = icone;
            this.Titulo = titulo;
            this.Cor = cor;
        }
    }
}
