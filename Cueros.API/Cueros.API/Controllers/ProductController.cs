using Cueros.API.Models;
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
        public object GetAll()
        {
            return Json(CuerosContext.DB.Products.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public object Get(int productID)
        {
            return Json(CuerosContext.DB.Products.Find(productID), JsonRequestBehavior.AllowGet);
        }
    }
}
