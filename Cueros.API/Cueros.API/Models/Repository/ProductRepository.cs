using Cueros.API.Models.APIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Cueros.API.Controllers.API.ErrorHandler;

namespace Cueros.API.Models
{
    public class ProductRepository
    {
        public object Get()
        {
            try
            {
                return APIFunctions.SuccessResult(CuerosContext.DB.Products.ToList(), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }

        public object Get(int productID)
        {
            try
            {
                var product = CuerosContext.DB.Products.Find(productID);
                if (product == null)
                {
                    return APIFunctions.ErrorResult(string.Format(JsonMessage.NotFound, "producto"));
                }
                return APIFunctions.SuccessResult(product, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }

        public object Add(Product product)
        {
            try
            {
                if (!ValidateProduct(product))
                {
                    return APIFunctions.ErrorResult("Error en los datos");
                }
                var newProduct = CuerosContext.DB.Products.Add(product);
                CuerosContext.DB.SaveChanges();
                return APIFunctions.SuccessResult(newProduct.ProductID, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }

        private bool ValidateProduct(Product product)
        {
            return true;
        }
    }
}