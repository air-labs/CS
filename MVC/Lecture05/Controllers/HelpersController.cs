using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture04.Models;

namespace Lecture04.Controllers
{
    public class HelpersController : Controller
    {
        
        public ActionResult Index()
        {
            return View("S07",new DataBase().GetDepartments());
        }

    }
}
