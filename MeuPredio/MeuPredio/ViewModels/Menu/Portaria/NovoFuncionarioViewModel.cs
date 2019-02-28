using MeuPredio.Models;
using MeuPredio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MeuPredio.ViewModels.Menu.Portaria
{
    public class NovoFuncionarioViewModel : BaseViewModel
    {
        #region Propriedade
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { SetProperty(ref _nome, value); }
        }

        private ApiService apiService;
        #endregion

        #region Commands
        public ICommand NovoFuncionarioCommand { get { return new Command(OnNovoFuncionarioExecute); } }

        #endregion

        #region Construtor
        public NovoFuncionarioViewModel()
        {
            apiService = new ApiService();
        }
        #endregion

        #region Métodos

        private async void OnNovoFuncionarioExecute(object obj)
        {
            var funcionario = new Funcionarios
            {
                NomeFuncionario = Nome,
            };

            var response = await apiService.Post("https://backandmeupredio2.azurewebsites.net", " /api", "/Funcionarios", funcionario);

            #endregion
        }
    }
}

