using PuraFruta.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PuraFruta.Windows
{
    class NewOrderWindowViewModel : INotifyPropertyChanged
    {
        public NewOrderWindowViewModel()
        {
            AddItemsToOrderCommand = new RelayCommand(AddItemToOrder);
            SendOrderCommand = new RelayCommand(SendOrder);
        }

        #region Commands
        public RelayCommand AddItemsToOrderCommand { get; set; }
        public RelayCommand SendOrderCommand { get; set; }
        #endregion

        #region Properties
        //private Customer _selectedCustomer;
        //public Customer SelectedCustomer
        //{
        //    get
        //    {
        //        return _selectedCustomer;
        //    }
        //    set
        //    {
        //        _selectedCustomer = value;
        //        SetCustomer();
        //        OnPropertyChanged();
        //    }
        //}

        //private Order _order;
        //public Order Order
        //{
        //    get
        //    {
        //        return _order;
        //    }
        //    set
        //    {
        //        _order = value;
        //        OnPropertyChanged();
        //    }
        //}
        #endregion

        private void SetCustomer()
        {
            //Order.Customer = SelectedCustomer;
        }

        private void AddItemToOrder()
        {
            //TODO var fruitOrder = new fruitOrder()....
            //Order.FruitOrders.Add(fruitOrder);
        }

        private void SendOrder()
        {
            //var invoice = new Invoice(Order);
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
