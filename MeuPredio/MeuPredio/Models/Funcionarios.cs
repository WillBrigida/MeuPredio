﻿using MeuPredio.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPredio.Models
{
    public class Funcionarios : BaseViewModel
    {
        public int IdFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string SobrenomeFuncionario { get; set; }
        public string TelefoneFuncionario { get; set; }
        public string DescricaoFuncionario { get; set; }
        public string ObservaçãoFuncionario { get; set; }
        public string FuncaoFuncionario { get; set; }
        public string StatusFuncionario { get; set; }
        public string ImagemFuncionario { get; set; }

        private bool _isComplete;

        public bool IsComplete
        {
            get { return _isComplete; }
            set {SetProperty(ref _isComplete , value); }
        }

        public string ImagemFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImagemFuncionario))
                {
                    return "imagePerfil.png";
                }
                return string.Format("https://backandmeupredio2.azurewebsites.net{0}", ImagemFuncionario.Substring(1));
            }
            
        }
    }
}
