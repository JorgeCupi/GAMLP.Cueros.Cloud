using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace Cueros.Web.Models
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Composed> Composed { get; set; }
        public DbSet<Supplies> Supplies { get; set; }

        public Context():base()
        {

        }
    }
}