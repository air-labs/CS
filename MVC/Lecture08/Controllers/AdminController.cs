using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture08.Models;
using System.Web.Security;

namespace Lecture08.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public string Register(LogOnViewModel userData)
        {
            Membership.CreateUser(userData.UserName, userData.Password);
            return "Пользователь " + userData.UserName + " с паролем " + userData.Password + " создан";
        }
    }
}
