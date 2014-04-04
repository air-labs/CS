using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture06.Models;

namespace Lecture06.Controllers
{
    public class ValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action1(Contacts contacts)
        {
            if (string.IsNullOrWhiteSpace(contacts.Street))
                ModelState.AddModelError("Street", "Поле является обязательным");

            if (string.IsNullOrWhiteSpace(contacts.EMail) && string.IsNullOrWhiteSpace(contacts.Phone))
                ModelState.AddModelError("", "Нужно указать телефон или e-mail");

            if (ModelState.IsValid)
                ViewBag.Correct = true;
            
            return View("Index",contacts);
        }

        public ActionResult Action2(Contacts contacts)
        {
            if (ModelState.IsValid)
                ViewBag.Correct = true;
            return View("Index", contacts);
        }

        public ActionResult Index1(Contacts contacts)
        {
            return View();
        }

    }
}
