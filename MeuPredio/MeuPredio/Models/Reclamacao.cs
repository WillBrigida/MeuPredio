using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class Reclamacao
    {
        public TipoReclamacao Tipo  { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Pessoas Pessoa { get; set; }
    }
}
