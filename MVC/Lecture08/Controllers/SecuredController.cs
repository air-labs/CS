using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture08.Controllers
{
    [Authorize]
    public class SecuredController : Controller
    {

        public string  Index()
        {
            return "Авторизация пройдена<br>Пользователь: " + User.Identity.Name;
        }

    }
}
