using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture05.Models;

namespace Lecture05.Controllers
{
    public class TestableController : Controller
    {
        IDataBase db;
        public TestableController(IDataBase db)
        {
            this.db = db;
        }

        public ActionResult Index(string search)
        {
            var data = db.GetDepartments()
                .Where(z => search==null || z.Name.Contains(search))
                .ToArray();
            return View(data);
        }
    }
}
