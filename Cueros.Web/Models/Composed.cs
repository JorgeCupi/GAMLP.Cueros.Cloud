using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Composed
    {
        public int ComposedID { get; set; }
        
        public int ProductID { get; set; }
        public int MaterialID { get; set; }
        [ForeignKey("MaterialID")]
        public virtual Material Material { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}