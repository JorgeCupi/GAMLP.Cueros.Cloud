using Cueros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var picture = new Picture()
            {
                Decription = "Descripcion de prueba",
                URL = "djksajdlsa.jpg"
            };
            CuerosContext.DB.Pictures.Add(picture);
            CuerosContext.DB.SaveChanges();
            return View();
        }
    }
}
