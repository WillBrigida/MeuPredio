using MeuPredio.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class Pessoas : IEntity
    {
        public int ID { get ; set; }
        public string NomePessoa { get; set; }
        public string SobrenomePessoa { get; set; }
        public string TelefonePessoa { get; set; }
        

        public override string ToString()
        {
            var nomeCompleto = String.Format ("{0} {1}", NomePessoa, SobrenomePessoa);
            return nomeCompleto;
        }
    }
    
}
