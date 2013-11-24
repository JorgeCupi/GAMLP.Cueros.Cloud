using Cueros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class SuppliesController : Controller
    {
        [HttpGet]
        public object GetAll()
        {
            return Json(CuerosContext.DB.Supplies.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}
