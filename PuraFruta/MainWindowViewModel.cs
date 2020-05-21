using PuraFruta.Helpers;
using PuraFruta.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PuraFruta
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            AddStockCommand = new RelayCommand(AddStock);
            NewOrderCommand = new RelayCommand(NewOrder);
        }

        #region Commands
        public RelayCommand AddStockCommand { get; set; }
        public RelayCommand NewOrderCommand { get; set; }
        #endregion

        #region Properties
        #endregion

        private void AddStock()
        {
            var window = new AddStockWindow();
            window.DataContext = new AddStockWindowViewModel();
            window.Show();
        }

        private void NewOrder()
        {
            var window = new NewOrderWindow();
            window.DataContext = new NewOrderWindowViewModel();
            window.Show();
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

}
