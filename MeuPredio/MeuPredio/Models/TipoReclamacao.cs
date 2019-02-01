using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class TipoReclamacao
    {
        public enum EnumTipo
        {
            Estrutural,
            Comportamental,
            Convivência,
            Funcionários,
            Elevadores
        };

        public EnumTipo ListaEnum { get; set; }

        public TipoReclamacao( EnumTipo lista)
        {
            this.ListaEnum = lista;
        }
    }
}
