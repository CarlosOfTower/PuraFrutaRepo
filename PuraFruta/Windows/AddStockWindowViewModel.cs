using PuraFruta.Helpers;
using PuraFruta.Models;
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
    class AddStockWindowViewModel : INotifyPropertyChanged
    {
        public AddStockWindowViewModel()
        {
            AddStockCommand = new RelayCommand (AddStock);
            AddNewFruitCommand = new RelayCommand(AddNewFruit);
        }

        #region Commands
        public RelayCommand AddStockCommand { get; set; }
        public RelayCommand AddNewFruitCommand { get; set; }
        #endregion

        #region Properties
        //TODO initiate Fruits and Units from DB -> Dependency Injection in Constructor
        public List<Fruit> Fruits => new List<Fruit>();
        public List<UnitMeasure> FruitUnitsList => new List<UnitMeasure>();

        #region Existing Fruit
        private string _selectedFruit;
        public string SelectedFruit
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

        private decimal _amount;
        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }
        private decimal _priceUnitPurchase;
        public decimal PriceUnitPurchase
        {
            get
            {
                return _priceUnitPurchase;
            }
            set
            {
                _priceUnitPurchase = value;
                OnPropertyChanged();
            }
        }
        private decimal _priceUnitSell;
        public decimal PriceUnitSell
        {
            get
            {
                return _priceUnitSell;
            }
            set
            {
                _priceUnitSell = value;
                OnPropertyChanged();
            }
        }

        private UnitMeasure _fruitUnit;
        public UnitMeasure FruitUnit
        {
            get
            {
                return _fruitUnit;
            }
            set
            {
                _fruitUnit = value;
                OnPropertyChanged();
            }
        }
        #endregion
        #region New Fruit
        private string _newFruitName;
        public string NewFruitName
        {
            get
            {
                return _newFruitName;
            }
            set
            {
                _newFruitName = value;
                OnPropertyChanged();
            }
        }

        private decimal _newFruitAmount;
        public decimal NewFruitAmount
        {
            get
            {
                return _newFruitAmount;
            }
            set
            {
                _newFruitAmount = value;
                OnPropertyChanged();
            }
        }

        private decimal _newFruitPriceUnitPurchase;
        public decimal NewFruitPriceUnitPurchase
        {
            get
            {
                return _newFruitPriceUnitPurchase;
            }
            set
            {
                _newFruitPriceUnitPurchase = value;
                OnPropertyChanged();
            }
        }
        private decimal _newFruitPriceUnitSell;
        public decimal NewFruitPriceUnitSell
        {
            get
            {
                return _newFruitPriceUnitSell;
            }
            set
            {
                _newFruitPriceUnitSell = value;
                OnPropertyChanged();
            }
        }

        private UnitMeasure _newFruitUnit;
        public UnitMeasure NewFruitUnit
        {
            get
            {
                return _newFruitUnit;
            }
            set
            {
                _newFruitUnit = value;
                OnPropertyChanged();
            }
        }

        private string _newFruitDescription;
        public string NewFruitDescription
        {
            get
            {
                return _newFruitDescription;
            }
            set
            {
                _newFruitDescription = value;
                OnPropertyChanged();
            }
        }

        #endregion
        #endregion

        private void AddStock()
        {
            if (Fruits.Select(f=>f.Name).Contains(SelectedFruit))
            {
                Fruits.FirstOrDefault(f => f.Name == SelectedFruit).AddStock(Amount);
            }
            else
            {
            }
        }

        private void AddNewFruit()
        {
            Fruit newFruit = new Fruit(NewFruitName, NewFruitDescription, NewFruitAmount, NewFruitUnit, NewFruitPriceUnitPurchase, NewFruitPriceUnitSell);
            Fruits.Add(newFruit);
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
