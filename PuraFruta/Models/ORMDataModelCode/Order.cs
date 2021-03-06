﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace PuraFruta.Models.ORMDataModel
{

    public partial class Order
    {
        public Order(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        internal void SetTime()
        {
            Date = DateTime.Now.ToString("HH:mm:ss");
        }
    }

}
