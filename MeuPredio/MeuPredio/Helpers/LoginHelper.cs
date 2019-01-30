using MeuPredio.DataBase;
using MeuPredio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeuPredio.Helpers
{
    public class LoginHelper
    {
        #region Propriedades

        #endregion

        #region Commands

        #endregion

        #region Construtor

        #endregion

        #region MyRegion

        #endregion
        readonly RealmRepository<LoginSenha> _realmRepository;


        public LoginHelper()
        {
            _realmRepository = new RealmRepository<LoginSenha>();
        }

        bool status;
        public bool SalvarLoginSenha(string login, string senha)
        {
            var loginSenhaBase = _realmRepository.GetAll().Where(l => l.Login == login);

            if (loginSenhaBase.Count() == 0)
            {
                var log = new LoginSenha();
                log.Login = login;
                log.Senha = senha;

                _realmRepository.Insert(log);
                status = true;
            }
            else
            {
                foreach (var item in loginSenhaBase)
                {
                    if (login == item.Login && senha == item.Senha)
                    {
                        status = true;
                    }
                    status = false;
                }
            }

            return status;
        }

    }
}
