using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Line { get; set; }
        public string Model { get; set; }
        public string Season { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}