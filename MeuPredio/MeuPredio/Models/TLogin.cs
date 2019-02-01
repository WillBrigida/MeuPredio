using MeuPredio.DataBase;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    class TLogin : RealmObject, IEntity
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool LembrarSenha { get; set; }
    }

}
