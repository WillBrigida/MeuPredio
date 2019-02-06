using MeuPredio.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeuPredio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AtendimentosPage : TabbedPage
    {
        public AtendimentosPage()
        {
            InitializeComponent();
            this.BindingContext = new AtendimentosViewModel();
        }

        protected override bool OnBackButtonPressed() // Desativa o botão de voltar
        {
            return true;
        }
    }
}