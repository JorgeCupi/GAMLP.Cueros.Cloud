using Cueros.API.Models;
using Cueros.API.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(new CategoryRepository().Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Get(int CategoryID)
        {
            return Json(CuerosContext.DB.Categories.Find(CategoryID), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetByCategoryID(int CategoryID)
        {
            var result = new CategoryRepository().GetByCategoryID(CategoryID);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}