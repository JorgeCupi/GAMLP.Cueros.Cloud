using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cueros.Web.Models
{
    public class Initializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            #region Pictures
            Picture SupplierPicOne = new Picture { Description = "Distribuidora Arte y Cuero", URL = "https://www.dropbox.com/s/3y6jv74ijc6xo51/supplierArteCuero.jpg" };
            Picture SupplierPicTwo = new Picture { Description = "Distribuidora Siensa", URL = "https://www.dropbox.com/s/yyix54danh7dkx5/supplierCiensa.jpg" };
            Picture SupplierPicThree = new Picture { Description = "Distribudora America", URL = "https://www.dropbox.com/s/6hsbhih60v9497y/supplierAmerica.jpg" };

            Picture MaterialPicOne = new Picture { Description = "Cierres", URL = "https://www.dropbox.com/s/ywhyxoz1uoepxj2/materialZip.jpg"};
            Picture MaterialPicTwo = new Picture { Description = "Hilos", URL = "https://www.dropbox.com/s/lzpjq35epolxvhk/materialThread.jpg" };
            Picture MaterialPicThree = new Picture { Description = "Cuero", URL = "https://www.dropbox.com/s/n2ff0s3udant2v7/materialLeather.JPG" };
            Picture MaterialPicFour = new Picture { Description = "Botones", URL = "https://www.dropbox.com/s/cj4xngdovwgbcs7/materialButton.jpg" };

            Picture ProductPicOne = new Picture { Description = "Chaqueta de cuero", URL = "https://www.dropbox.com/s/fzfnbrdh99n9wv9/productJacketOne.jpg" };
            Picture ProductPicTwo = new Picture { Description = "Chaqueta de cuero", URL = "https://www.dropbox.com/s/amoqahc2rcr1krh/productJacketTwo.jpg" };
            Picture ProductPicThree = new Picture { Description = "Chaleco de cuero", URL = "https://www.dropbox.com/s/eewlfwc5k7up7ul/productVestOne.jpg" };
            Picture ProductPicFour = new Picture { Description = "Chaleco de cuero", URL = "https://www.dropbox.com/s/ukoelfzw0xx74zr/productVestTwo.jpg" };
            Picture ProductPicFive = new Picture { Description = "Chaleco de cuero", URL = "https://www.dropbox.com/s/7xfmv03tn3r03a1/productVestThree.jpg" };
            Picture ProductPicSix = new Picture { Description = "Pantalon de cuero", URL = "https://www.dropbox.com/s/0t29ayxrw0li5of/productPantOne.jpg" };
            Picture ProductPicSeven = new Picture { Description = "Pantalon de cuero", URL = "https://www.dropbox.com/s/qmi84l2akr4u0th/productPantTwo.jpeg" };
            Picture ProductPicEight = new Picture { Description = "Pantalon de cuero", URL = "https://www.dropbox.com/s/yfwxv4s8qukt2n9/productPantThree.jpg" };

            context.Pictures.Add(ProductPicOne);
            context.Pictures.Add(ProductPicTwo);
            context.Pictures.Add(ProductPicThree);
            context.Pictures.Add(ProductPicFour);
            context.Pictures.Add(ProductPicFive);
            context.Pictures.Add(ProductPicSix);
            context.Pictures.Add(ProductPicSeven);
            context.Pictures.Add(ProductPicEight);

            context.SaveChanges();
            #endregion

            #region Suppliers
            Supplier SupplierOne = new Supplier { Address = "Miraflores #234" , City = "La Paz", Country= "Bolivia", Email = "arteycuero@outlook.com", Name = "Arte y Cuero", PhoneNumber= "+59175546398", Picture = SupplierPicOne};

            Supplier SupplierTwo = new Supplier { Address = "Av Mercado #234", City = "Oruro", Country = "Bolivia", Email = "info@siensa.com", Name = "Siensa", PhoneNumber = "+59176932159", Picture = SupplierPicTwo };

            Supplier SupplierThree = new Supplier { Address = "Miraflores #3223" , City = "Santa Cruz", Country= "Bolivia", Email = "informacion@distribuidoraamerica.com", Name = "Distribuidora America", PhoneNumber= "+59166598742", Picture = SupplierPicThree};

            context.Suppliers.Add(SupplierOne);
            context.Suppliers.Add(SupplierTwo);
            context.Suppliers.Add(SupplierThree);
            context.SaveChanges();
            #endregion

            #region Materials
            Material materialOne = new Material { CommercialName = "Cierres", Name = "Cierres", Picture = MaterialPicOne, Suppliers = new List<Supplier> { SupplierOne, SupplierTwo, SupplierThree}, UnitPrice= 4, UnitType = "unidades" };

            Material materialTwo = new Material { CommercialName = "Hilos", Name = "Hilos", Picture = MaterialPicTwo, Suppliers = new List<Supplier> { SupplierTwo, SupplierThree }, UnitPrice = 15, UnitType = "caja" };

            Material materialThree = new Material { CommercialName = "Cuero", Name = "Cuero", Picture = MaterialPicThree, Suppliers = new List<Supplier> { SupplierThree }, UnitPrice = 50, UnitType = "metros cuadrados" };

            Material materialFour = new Material { CommercialName = "Botones", Name = "Botones", Picture = MaterialPicFour, Suppliers = new List<Supplier> { SupplierOne, SupplierThree }, UnitPrice = 5, UnitType = "caja" };

            context.Materials.Add(materialOne);
            context.Materials.Add(materialTwo);
            context.Materials.Add(materialThree);
            context.Materials.Add(materialFour);
            context.SaveChanges();
            #endregion

            #region Products
            Product productOne = new Product { Line = "Chaquetas", Materials = new List<Material> { materialOne, materialTwo, materialThree, materialTwo }, Model = "STR - 5", Name = "Chaqueta juvenil", Pictures = new List<Picture> { ProductPicOne}, Season= "Verano" };

            Product productTwo = new Product { Line = "Chaquetas", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STR - 4", Name = "Chaqueta sport", Pictures = new List<Picture> { ProductPicTwo }, Season = "Verano" };

            Product productThree = new Product { Line = "Chalecos", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STF - 3", Name = "Chaleco juvenil", Pictures = new List<Picture> { ProductPicThree }, Season = "Invierno" };

            Product productFour = new Product { Line = "Chalecos", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STF - 5", Name = "Chaleco sport", Pictures = new List<Picture> { ProductPicFour }, Season = "Primavera" };

            Product productFive = new Product { Line = "Chalecos", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STF - 2", Name = "Chaleco casual", Pictures = new List<Picture> { ProductPicFive }, Season = "Invierno" };

            Product productSix = new Product { Line = "Pantalones", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STP - 1", Name = "Pantalon juvenil", Pictures = new List<Picture> { ProductPicSix }, Season = "Otono" };

            Product productSeven = new Product { Line = "Pantalones", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STP - 2", Name = "Pantalon casual", Pictures = new List<Picture> { ProductPicSeven }, Season = "Primavera" };

            Product productEight = new Product { Line = "Pantalones", Materials = new List<Material> { materialOne, materialTwo, materialTwo, materialTwo }, Model = "STP - 3", Name = "Pantalon deportivo", Pictures = new List<Picture> { ProductPicEight }, Season = "Verano" };

            context.Products.Add(productOne);
            context.Products.Add(productTwo);
            context.Products.Add(productThree);
            context.Products.Add(productFour);
            context.Products.Add(productFive);
            context.Products.Add(productSix);
            context.Products.Add(productSeven);
            context.Products.Add(productEight);
            context.SaveChanges();
            #endregion
            #region relations
            Composed composed = new Composed()
            {
                MaterialID = context.Materials.Find(1).ProductID,
                ProductID = context.Products.Find(1).ProductID,
            };
            context.SaveChanges();
            #endregion
        }
    }
}