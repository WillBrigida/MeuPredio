using MeuPredio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MeuPredio.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Notificação
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void Notificar([CallerMemberName] string prop = null)

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string prop = null)

        {
            if (EqualityComparer<T>.Default.Equals(storage, value))

            {
                return false;
            }

            storage = value;

            Notificar(prop);

            return true;
        }
        #endregion

        #region Validação
        private bool isVisible;

        public bool IsVisible
        {
            get { return isVisible; }
            set { this.SetProperty(ref isVisible, value); }
        }

        private bool isVisible2;

        public bool IsVisible2
        {
            get { return isVisible2; }
            set { this.SetProperty(ref isVisible2, value); }
        }


       

        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { this.SetProperty(ref isEnabled, value); }
        }


        private bool isEnabled2;

        public bool IsEnabled2
        {
            get { return isEnabled2; }
            set { this.SetProperty(ref isEnabled2, value); }
        }


        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set { this.SetProperty(ref isRunning, value); }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { this.SetProperty(ref status, value); }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { SetProperty(ref color, value); }
        }



        #endregion
        public virtual Task LoadAsync(object[] args) => Task.FromResult(true);

        public virtual Task LoadAsync() => Task.FromResult(true);

        protected NavigationService Navigation => NavigationService.Current;

    }
}