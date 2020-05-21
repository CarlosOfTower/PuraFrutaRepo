using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace PuraFruta.Models.ORMDataModel
{

    public partial class FruitOrder
    {
        public FruitOrder(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
