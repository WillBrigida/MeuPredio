using MeuPredio.ViewModels;
using MeuPredio.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MeuPredio.Services
{
    public class NavigationService
    {
        static Lazy<NavigationService> LazyNavi = new Lazy<NavigationService>(() => new NavigationService());
        public static NavigationService Current => LazyNavi.Value;


        private Page GetViewModelLocator<TViewModel>(params object[] args) where TViewModel : BaseViewModel
        {
            var viewModelType = typeof(TViewModel);
            var viewModelTypeName = viewModelType.Name;
            var viewModelWordLength = "ViewModel".Length;

            var namespaceName = typeof(BaseViewModel).AssemblyQualifiedName.Split('.')[0];

            var viewTypeName = $"{ namespaceName}.Views.{ viewModelTypeName.Substring(0, viewModelTypeName.Length - viewModelWordLength)}Page";

            var viewType = Type.GetType(viewTypeName);

            var page = Activator.CreateInstance(viewType) as Page;

            var viewModel = Activator.CreateInstance(viewModelType, args);
            if (page != null)
            {
                page.BindingContext = viewModel;
            }

            return page;
        }

        

        public async Task PushAsync<TViewModel>(bool modal = false, params object[] args) where TViewModel : BaseViewModel
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;

            var page = GetViewModelLocator<TViewModel>(args);

            if (modal)
                await Application.Current.MainPage.Navigation.PushModalAsync(page);
            else
                await navPage.PushAsync(page);

          

            await (page.BindingContext as BaseViewModel).LoadAsync(args);
        }

        public void NavigateMenu(string titulo)
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;

            switch (titulo)
            {
                case "Portaria":
                    mdp.Detail = new NavigationPage(new PortariaPage());
                    break;
                case "Reclamações":
                    mdp.Detail = new NavigationPage(new ReclamacoesPage());
                    break;
                case "Informações":
                    mdp.Detail = new NavigationPage(new InformacoesPage());
                    break;
                case "Atendimentos":
                    mdp.Detail = new NavigationPage(new AtendimentosPage());
                    break;
                case "Scanner":
                    mdp.Detail = new NavigationPage(new ScannerPage());
                    break;

            }
        }

        public async Task PopAsync() =>
           await Application.Current.MainPage.Navigation.PopAsync();

        public async Task PopToRootAsync() =>
          await Application.Current.MainPage.Navigation.PopToRootAsync();



    } 
}