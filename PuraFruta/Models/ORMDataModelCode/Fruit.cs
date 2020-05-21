using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace PuraFruta.Models.ORMDataModel
{

    public partial class Fruit
    {
        public Fruit(Session session) : base(session) { }

        public Fruit(string newFruitName, string newFruitDescription, decimal newFruitAmount, UnitMeasure newFruitUnit, decimal newFruitPriceUnitPurchase, decimal newFruitPriceUnitSell)
        {
            Name = newFruitName;
            Description = newFruitDescription;
            Stock = (double)newFruitAmount;
            UnitMeasure = newFruitUnit;
            UnitPricePurchase= newFruitPriceUnitPurchase;
            UnitPriceSell = newFruitPriceUnitSell;
            DateInserted = DateTime.Now.ToString("HH:mm:ss");
            DateLastStockInserted = DateTime.Now.ToString("HH:mm:ss");
        }

        public override void AfterConstruction() { base.AfterConstruction(); }

        internal void AddStock(decimal amount)
        {
            Stock += (double)amount;
            DateLastStockInserted = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}
