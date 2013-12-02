using Cueros.API.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string Name { get; set; }
        public string CommercialName { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public string Color { get; set; }
    }
}