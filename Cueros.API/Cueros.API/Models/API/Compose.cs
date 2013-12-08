using Cueros.API.Enumerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class Compose
    {
        public int ComposeID { get; set; }

        public int ProductID { get; set; }
        public int MaterialID { get; set; }

        public int Quantity { get; set; }
        public Unit Unit { get; set; }
        [ForeignKey("MaterialID")]
        public virtual Material Material { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}