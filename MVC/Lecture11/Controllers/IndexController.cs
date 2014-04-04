using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using Lecture11.Models;
using Lecture11.Infrastructure;

namespace Lecture11.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Action1(Employee emp)
        {
            return View(emp);
        }

        public ActionResult Action2(
            //    [Bind(Include="FirstName,LastName")]
            Employee emp)
        {
            return View(emp);
        }

        public ActionResult Action3(Employee emp)
        {
            return View(emp);
        }

        public ActionResult Action4(string[] strings)
        {
            if (strings == null) strings = new string[] { "A", "B", "C" };
            return View(strings);
        }

        public ActionResult Action5(Employee[] emps)
        {
            if (emps == null)
            {
                emps = new Employee[]
                {
                    new Employee { FirstName="John", LastName="Smith" },
                    new Employee { FirstName="Alex", LastName="Taylor" }
                };
            }
            return View(emps);
        }

        public ActionResult Action6(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return View();
            }
            else
            {
                var entry = new byte[file.ContentLength];
                file.InputStream.Read(entry, 0, entry.Length);
                return File(entry, file.ContentType);
            }
        }

        public ActionResult Action7(int[] array)
        {
            if (array == null) array = new int[] { 0, 0, 0 };
            return View(array);
        }

        public ActionResult Action8(IntArrayHolder holder)
        {
            if (holder == null) holder = new IntArrayHolder();
            return View(holder);
        }

        public ActionResult Action9(
            [ModelBinder(typeof(EmployeeModelBinder))]
            Employee emp)
        {
            if (emp == null) emp = new Employee();
            return View(emp);
        }

        public string Action10(User user)
        {
            return "Пользователь: "+user.Name;
        }
        


    }
}
