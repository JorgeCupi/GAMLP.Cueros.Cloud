using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Line { get; set; }
        public string Model { get; set; }
        public string Season { get; set; }
        public virtual ICollection<Picture> Pictures{ get; set; }
        public virtual ICollection<Material> Materials{ get; set; }
    }
}