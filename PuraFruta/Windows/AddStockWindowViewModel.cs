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
    class AddStockWindowViewModel : INotifyPropertyChanged
    {
        public AddStockWindowViewModel()
        {
            AddStockCommand = new RelayCommand (AddStock);
        }

        #region Commands
        public RelayCommand AddStockCommand { get; set; }
        #endregion

        #region Properties
        //TODO public List<Fruit> Fruits => new List<Fruit> .Select
        //TODO public Fruit SelectedFruit { get; set; }

        private int _amount;
        public int Amount
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

        private string _fruitUnit;
        public string FruitUnit
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

        private void AddStock()
        {
            //TODO Animation to show Added
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
