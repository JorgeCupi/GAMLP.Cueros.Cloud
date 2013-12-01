using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.API
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime Date { get; set; }
        
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}