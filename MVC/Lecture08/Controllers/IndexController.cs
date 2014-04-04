using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Lecture08.Controllers
{
    public class IndexController : Controller
    {

        [Authorize]
        public string SecuredIndex()
        {
            return "Авторизация пройдена<br>Пользователь: " + User.Identity.Name;
        }


        public ActionResult Index()
        {
            return View();
        }


        [Authorize(Users = "Admin1,Admin2")]
        public string AdminsOnly()
        {
            return "Пользователь Admin1 или Admin2";
        }


        [Authorize(Roles="Admin,Manager")]
        public string AdminOrManager()
        {
            return "Роль Admin или Manager у пользователя: " + User.Identity.Name;
        }



    }
}
