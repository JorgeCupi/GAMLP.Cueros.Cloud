using Cueros.API.Enumerators;
using Cueros.API.Models;
using Cueros.API.Models.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cueros.API.Models
{
    public class CuerosContext:DbContext
    {
        private static CuerosContext db=new CuerosContext ();
        public static CuerosContext DB
        {
            get { return db; }
            set { db = value; }
        }
        public DbSet<Compose> Compose { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supplies> Supplies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories {get;set;}

        public CuerosContext():base()
        {

        }

        public class CuerosInitializer : CreateDatabaseIfNotExists<CuerosContext>
        {
            protected override void Seed(CuerosContext context)
            {
                base.Seed(context);
            }
        }
    }
}