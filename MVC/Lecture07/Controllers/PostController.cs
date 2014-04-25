using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture06.Models;

namespace Lecture06.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(string value)
        {
            return "value: " + value;
        }

        public string Action1(bool boolean, ConsoleColor color)
        {
            return "boolean: " + boolean.ToString() + "<br/>color: " + color.ToString();
        }

        public string Action2(string str)
        {
            return "str: " + str;
        }

        public string Action3(Book book)
        {
            return book.ToString();
        }
    }
}
