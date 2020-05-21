using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuraFruta.Models
{
    public enum MeasureUnit
    {
        [Description("Kgs")]
        Kgs = 0,
        [Description("Gramos")]
        Gramos = 1,
        [Description("Manojos")]
        Manojo = 2,
        [Description("Piezas")]
        Pieza = 3,
        [Description("Bolsas")]
        Bolsa = 4
    }
}
