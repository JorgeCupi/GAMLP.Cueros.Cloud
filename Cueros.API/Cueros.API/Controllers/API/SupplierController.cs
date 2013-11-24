using Cueros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class SupplierController : Controller
    {
        [HttpGet]
        public object GetAll()
        {
            return Json(CuerosContext.DB.Suppliers.ToList(), JsonRequestBehavior.AllowGet); 
        }
        [HttpGet]
        public object Get(int supplierID)
        {
            return Json(CuerosContext.DB.Suppliers.Find(supplierID), JsonRequestBehavior.AllowGet);
        }
    }
}
