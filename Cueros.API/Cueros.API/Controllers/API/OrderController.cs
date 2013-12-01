using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models.API;
using Cueros.API.Models.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers.API
{
    public class OrderController : Controller
    {
        [HttpGet]
        [APIErrorHandler]
        public JsonResult GetAll()
        {
            var result = new OrderRepository().Get();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [APIErrorHandler]
        public JsonResult GetByProductID(int productID)
        {
            var result = new OrderRepository().GetByProductID(productID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [APIErrorHandler]
        public JsonResult Add(string orderData)
        {
            var result = new OrderRepository().Add(JsonConvert.DeserializeObject<Order>(orderData));
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
