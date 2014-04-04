using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace Lecture02.Controllers
{
    public class IndexController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

       
    }
}