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

        public CuerosContext():base()
        {

        }
        public class MyGymInitializer : DropCreateDatabaseAlways<CuerosContext>
        {
            protected override void Seed(CuerosContext context)
            {
                #region Product
                context.Products.Add(new Product()
                    {
                        Name = "Chamarra de cuero",
                        Line = "No line",
                        Model = "No model",
                        Season = "No season",
                        //ProductionTime = new TimeSpan(12, 0, 0, 0),
                        Pictures = new List<Picture>()
                    });
                context.SaveChanges();
                #endregion
                #region Materials
                context.Materials.Add(new Material()
                    {
                        Name = "Chinela",
                        CommercialName = "Velboa bondeada rojo",
                        Quantity = 0.04,
                        Unit = Unit.dm2,
                        UnitPrice = 2.09,
                        Suppliers = new List<Supplier>()
                         {
                             new Supplier()
                            {
                                Name = "Arfat",
                                Email = "no_data@mail.com",
                                City = "La Paz",
                                PhoneNumber = 0000000,
                                Country = "Bolivia",
                                Address = "sin direccion # 0"
                            },
                            new Supplier()
                            {
                                Name = "Tomy",
                                Email = "no_data@mail.com",
                                City = "La Paz",
                                PhoneNumber = 0000000,
                                Country = "Bolivia",
                                Address = "sin direccion # 0"
                            },
                            new Supplier()
                            {
                                Name = "Aurelio Marca",
                                Email = "no_data@mail.com",
                                City = "La Paz",
                                PhoneNumber = 0000000,
                                Country = "Bolivia",
                                Address = "sin direccion # 0"
                            },
                            new Supplier()
                            {
                                Name = "Tiber",
                                Email = "no_data@mail.com",
                                City = "La Paz",
                                PhoneNumber = 0000000,
                                Country = "Bolivia",
                                Address = "sin direccion # 0"
                            }
                         }
                    });
                context.SaveChanges();
                #endregion
                #region Composed
                context.Compose.Add(new Compose()
                {
                    MaterialID=1,
                    Quantity=10,
                    Unit=Unit.dm2,
                    ProductID=1,
                });
                #endregion
                base.Seed(context);
            }
        }
    }
}