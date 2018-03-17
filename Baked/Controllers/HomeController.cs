using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baked.Models;

namespace Baked.Controllers
{
    public class HomeController : Controller
    {
        private BakeryEntities db = new BakeryEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Baked all the time.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me when I'm not Baked.";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "You want to eat this!";

            /*return to view the products from the db object:*/
            return View(db.Products.ToList());
        }

        public ActionResult Sales()
        {
            ViewBag.Message = "Showing you the money:";

            return View(db.SaleDetails.ToList());
        }
    }
}