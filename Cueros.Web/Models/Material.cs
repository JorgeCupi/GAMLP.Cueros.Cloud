using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Material
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string CommercialName { get; set; }
        public string UnitType { get; set; }
        public double UnitPrice { get; set; }
        public virtual Picture Picture { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}