using Cueros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class PictureController : Controller
    {
        [HttpGet]
        public object GetAll()
        {
            return Json(CuerosContext.DB.Pictures.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public object Get(int pictureID)
        {
            return Json(CuerosContext.DB.Pictures.Find(pictureID),JsonRequestBehavior.AllowGet);
        }
    }
}
