using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Season { get; set; }
        public int ProductionTime { get; set; }
        public int SoldUnits { get; set;}
        public Category Category{ get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }  
        public DateTime OnSaleDate { get; set; }
        public Product()
        {
            Pictures = new HashSet<Picture>();
        }
    }
}