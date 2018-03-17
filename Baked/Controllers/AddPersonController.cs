using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baked.Models;

namespace Baked.Controllers
{
    public class AddPersonController : Controller
    {
        // GET: AddPerson
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "PersonLastName, PersonFirstName," +
        "PersonEmail, PersonPhone")]Person formPerson)
        {
            BakeryEntities db = new BakeryEntities();
            Person dbPerson = new Person();

            dbPerson.PersonLastName = formPerson.PersonLastName;
            dbPerson.PersonFirstName = formPerson.PersonFirstName;
            dbPerson.PersonEmail = formPerson.PersonEmail;
            dbPerson.PersonPhone = formPerson.PersonPhone;
            dbPerson.PersonDateAdded = DateTime.Now;

            db.People.Add(dbPerson);
            db.SaveChanges();

            return View("Validation");
        }

        public ActionResult Validation()
        {
            return View();
        }
    }
}