using Cueros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class MaterialController : Controller
    {
        [HttpGet]
        public object GetAll()
        {
            return Json(CuerosContext.DB.Materials.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public object Get(int materialID)
        {
            return Json(CuerosContext.DB.Materials.Find(materialID),JsonRequestBehavior.AllowGet);
        }
    }
}
