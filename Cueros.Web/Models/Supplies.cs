using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Supplies
    {
        public int ProviderID { get; set; }
        
        public int SupplierID { get; set; }
        public int MaterialID { get; set; }

        [ForeignKey("SuplierID")]
        public Supplier Supplier { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
    }
}