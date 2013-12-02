using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.API
{
    public class BelongsTo
    {
        public int BelongsID { get; set; }

        public int ProductID { get; set; }
        public int CategorylID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product{ get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category{ get; set; }
    }
}