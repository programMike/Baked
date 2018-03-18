using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baked.Models;

namespace Baked.Controllers
{
    public class AddProductController : Controller
    {
        // GET: AddProduct
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ProductName, ProductPrice")]Product formProduct)
        {
            BakeryEntities db = new BakeryEntities();
            Product dbProduct = new Product();

            dbProduct.ProductName = formProduct.ProductName;
            dbProduct.ProductPrice = formProduct.ProductPrice;

            db.Products.Add(dbProduct);
            db.SaveChanges();

            return View("Verification");
        }
    }
}