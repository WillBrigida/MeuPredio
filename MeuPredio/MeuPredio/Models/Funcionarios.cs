using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class Funcionarios : Pessoas
    {
        public string FuncaoFuncionario { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Status { get; set; }


        public Funcionarios() 
        {
            
        }
       
    }

   
}
