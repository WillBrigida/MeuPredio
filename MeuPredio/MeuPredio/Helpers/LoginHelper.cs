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
        readonly RealmRepository<TLogin> _realmRepository;


        public LoginHelper()
        {
            _realmRepository = new RealmRepository<TLogin>();
        }

        bool status;
        public bool SalvarLoginSenha(string login, string senha)
        {
            var loginSenhaBase = _realmRepository.GetAll().Where(l => l.Login == login);

            if (loginSenhaBase.Count() == 0)
            {
                var log = new TLogin();
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


        static bool resposta;
        public bool VerificarLogin()
        {
            var contadorUsuario = _realmRepository.GetAll().Count();
            if (contadorUsuario == 0)
            {
                return resposta;
            }
            var ultimoUsuario = _realmRepository.GetAll().OrderByDescending(l => l.ID).FirstOrDefault();
            return resposta = ultimoUsuario.LembrarSenha;
        }
    }
}
