using Cueros.API.Controllers.API.ErrorHandler;
using Cueros.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [APIErrorHandler]
        public object GetAll()
        {
            return Json(new ProductRepository().Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [APIErrorHandler]
        public object Get(int productID)
        {
            var result = new ProductRepository().Get(productID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [APIErrorHandler]
        public JsonResult Add(string productData)
        {
            var result = new ProductRepository().Add(JsonConvert.DeserializeObject<Product>(productData));
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
