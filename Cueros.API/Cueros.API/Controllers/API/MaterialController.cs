using Cueros.API.Models;
using Cueros.API.Models.Repository;
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
        public JsonResult GetAll()
        {
            return Json(new MaterialRepository().Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Get(int materialID)
        {
            return Json(CuerosContext.DB.Materials.Find(materialID),JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetByProductID(int productID)
        {
            var result = new MaterialRepository().GetByProductID(productID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
