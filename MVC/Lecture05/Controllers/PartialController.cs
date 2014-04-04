using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture04.Models;

namespace Lecture04.Controllers
{
    public class PartialController : Controller
    {
        //
        // GET: /PartialView/

        public ActionResult Index()
        {
            return View("S03",new DataBase().GetDepartments());
        }

        public ActionResult EmpList()
        {
            var emps = new DataBase().GetDepartments().SelectMany(z => z.Employees).ToArray();
            return PartialView("PartialEmp",emps);
        }
    }
}
