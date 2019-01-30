using MeuPredio.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class SindicoViewModel : BaseViewModel
    {
        #region Propriedade
       

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { SetProperty(ref _telefone, value); }
        }

        private string _funcao;

        public string Funcao
        {
            get { return _funcao; }
            set { SetProperty(ref _funcao, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _imagem;

        public string Imagem
        {
            get { return _imagem; }
            set { SetProperty(ref _imagem, value); }
        }



        #endregion

        #region Commands

        #endregion

        #region Construtor
        public SindicoViewModel()
        {
            Nome = "Wandergleisson Costa";
            Funcao = "Sindico";
            Imagem = "wp.png";
            Telefone = "(21) 9999 - 9999";
            Email = "wander@gmail.com";
            
        }

        #endregion

        #region Métodos

       
        #endregion
    }
}
