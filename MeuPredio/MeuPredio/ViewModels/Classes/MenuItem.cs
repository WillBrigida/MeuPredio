using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.ViewModels.Classes
{
    public class MenuItem
    {
        public string Icone { get; set; }
        public string Titulo { get; set; }
        public string Cor { get; set; }

        public MenuItem(string icone, string titulo, string cor )
        {
            this.Icone = icone;
            this.Titulo = titulo;
            this.Cor = cor;
        }
    }
}
