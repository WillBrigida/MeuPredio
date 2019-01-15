using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class TipoReclamacao
    {
        //public string Tipo { get; set; }
        public enum EnumTipo
        {
            Estrutural,
            Comportamental,
            Convivencia
        };

        public EnumTipo ListaEnum { get; set; }

        public TipoReclamacao( EnumTipo lista)
        {
            //this.Tipo = tipo;
            this.ListaEnum = lista;
        }
    }
}
