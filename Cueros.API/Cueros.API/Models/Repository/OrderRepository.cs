using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models.API;
using Cueros.API.Models.APIFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cueros.API.Models.Repository
{
    public class OrderRepository
    {
        public object Get()
        {
            try
            {
                var result = CuerosContext.DB.Orders.ToList();
                return APIFunctions.SuccessResult(result, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        public object GetByProductID(int productID)
        {
            try
            {
                var result = from x in CuerosContext.DB.Orders.ToList() where x.ProductID == productID select x;
                return APIFunctions.SuccessResult(result.ToList(), JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }
        
        public object Add(Order order)
        {
            try
            {
                if (!ValidateOrder(order))
                {
                    //error x el numero de prendas
                    return APIFunctions.ErrorResult("Cantidad disponible excedida o error en datos de envio");
                }
                var newOrder = CuerosContext.DB.Orders.Add(order);
                return APIFunctions.SuccessResult(newOrder.OrderID, JsonMessage.Success);
            }
            catch (Exception e)
            {
                return APIFunctions.ErrorResult(e.Message);
            }
        }

        /// <summary>
        /// podemos cambiarlo x string y ver q message nos retorna
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private bool ValidateOrder(Order order)
        {
            var product = CuerosContext.DB.Products.Find(order.ProductID);
            if (product == null)
                return false;
            if (product.Quantity < order.Quantity)
                return false;
            product.Quantity -= order.Quantity;
            CuerosContext.DB.SaveChanges();
            return true;
        }
    }
}