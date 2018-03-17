using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baked.Models;

namespace Baked.Controllers
{
    public class EatThatController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        Message message = new Message();
        // GET: EatThat
        public ActionResult Index()
        {
            ViewBag.ProductKey = new SelectList(db.Products, "ProductKey", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ProductKey")]Product formProduct)
        {
            /*as simple as i did want the final project be with regard to just sending
             the cost value for one order of one product it did take 2 hours to find
             a query would provide the best solution, that i could think of.*/
            decimal costFromProductTableQuery = (from query in db.Products
                        where query.ProductKey == formProduct.ProductKey
                        select query.ProductPrice).FirstOrDefault();

            message.MessageText = costFromProductTableQuery.ToString();

            return View("Sale", message);
        }

        public ActionResult Sale(Message m)
        {
            return View(m);
        }
    }
}