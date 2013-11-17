using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class Supplies
    {
        public int SuppliesID { get; set; }

        public int SupplierID { get; set; }
        public int MaterialID { get; set; }

        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        [ForeignKey("MaterialID")]
        public virtual Material Material { get; set; }
    }
}