using Cueros.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cueros.Web.Controllers
{
    public class ProductsController : Controller
    {

        Context db = new Context();

        // GET: /Products/
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: /Products/Details/5
        public ActionResult Details(int id)
        {
            Product p = db.Products.Find(id);
            return View(p);
        }

        // POST: /Products/Create
        [HttpPost]
        public ActionResult Create(Product p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(p);
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: /Products/Edit/5
        public ActionResult Edit(int id)
        {
            Product p = db.Products.Find(id);
            return View(p);
        }

        // POST: /Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Product product = db.Products.Find(p.ProductID);
                    UpdateModel(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(p);
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
