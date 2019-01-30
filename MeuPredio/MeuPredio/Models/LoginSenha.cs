using MeuPredio.DataBase;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class LoginSenha : RealmObject, IEntity
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
