using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture08.Models;
using System.Web.Security;

namespace Lecture08.Controllers
{
    public class AccountController : Controller
    {
       
        public ActionResult LogOn()
        {
            return View();
        }

        public string LogOut()
        {
            FormsAuthentication.SignOut();
            return "Сеанс завершен";
        }
       

        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(model.UserName,model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Index"));
                }
                else
                {
                    ModelState.AddModelError("", "Неопознанные логин и пароль");
                }
            }
            
            return View();
        }
    }
}