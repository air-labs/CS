using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture06.Models;
using System.ComponentModel.DataAnnotations;

namespace Lecture06.Controllers
{
    public class ModelController : Controller
    {
        //
        // GET: /Model/

        public ActionResult Index1(Employee emp)
        {
            if (emp == null || emp.Name==null )emp = new Employee { Name = "John Smith" };
            return View(emp);
        }

        public ActionResult Index2(Employee emp)
        {
            if (emp == null || emp.Name == null) emp = new Employee { Name = "John Smith" };
            return View(emp);
        }

        public ActionResult Index3(JobApplication job)
        {
            return View(job);
        }
    }
}
