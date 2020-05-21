using PuraFruta.Helpers;
using PuraFruta.Models.ORMDataModel;
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
            //Order = new Order();
            RecoverLastCustomerOrderCommand = new RelayCommand(RecoverLastCustomerOrder);
            AddItemsToOrderCommand = new RelayCommand(AddItemToOrder);
            SendOrderCommand = new RelayCommand(SendOrder);
        }

        #region Commands
        public RelayCommand RecoverLastCustomerOrderCommand { get; set; }
        public RelayCommand AddItemsToOrderCommand { get; set; }
        public RelayCommand SendOrderCommand { get; set; }
        #endregion

        #region Properties
        //TODO Get from DB
        public List<Customer> Customers => new List<Customer>();
        public List<Fruit> Fruits => new List<Fruit>();

        private Order _order;
        public Order Order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
                OnPropertyChanged();
            }
        }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
                SetCustomer();
                OnPropertyChanged();
            }
        }
        private Fruit _selectedFruit;
        public Fruit SelectedFruit
        {
            get
            {
                return _selectedFruit;
            }
            set
            {
                _selectedFruit = value;
                OnPropertyChanged();
            }
        }

        private decimal _Quantity;
        public decimal Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
                OnPropertyChanged();
            }
        }
        #endregion

        private void SetCustomer()
        {
            Order.Customer = SelectedCustomer;
        }

        private void RecoverLastCustomerOrder()
        {
            if (SelectedCustomer == null) return;
            else
            {
                if (Order.FruitOrders.Count == 0)
                {
                    Order = SelectedCustomer.LastOrder;
                }
            }
        }

        private void AddItemToOrder()
        {
            FruitOrder fruitOrder = new FruitOrder(SelectedFruit, Quantity);
            Order.FruitOrders.Add(fruitOrder);
        }

        private void SendOrder()
        {
            Order.SetTime();
            //TODO Generate Bill
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
