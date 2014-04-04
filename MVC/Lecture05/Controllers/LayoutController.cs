using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture04.Models;

namespace Lecture04.Controllers
{
    public class LayoutController : Controller
    {
        //
        // GET: /Layout/

        public ActionResult Index()
        {
            return View("S05",new DataBase().GetDepartments());
        }

    }
}
