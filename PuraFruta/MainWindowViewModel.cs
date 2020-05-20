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

            AddStockWindowVM = new AddStockWindowViewModel();
            NewOrderWindowVM = new NewOrderWindowViewModel();
        }

        #region Commands
        public RelayCommand AddStockCommand { get; set; }
        public RelayCommand NewOrderCommand { get; set; }
        #endregion

        #region Properties
        public AddStockWindowViewModel AddStockWindowVM { get; set; }
        public NewOrderWindowViewModel NewOrderWindowVM { get; set; }
        #endregion

        private void AddStock()
        {
            var window = new AddStockWindow();
            window.DataContext = AddStockWindowVM;
            window.Show();
        }

        private void NewOrder()
        {
            var window = new NewOrderWindow();
            window.DataContext = NewOrderWindowVM;
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
