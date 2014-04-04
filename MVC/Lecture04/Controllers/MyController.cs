using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture03.Controllers
{
    public class MyController : Controller
    {
        public string Action1()
        {
            return "Action1<br/>Hello, MVC!";
        }

        public string Action2(int id)
        {
            var result = "Action2(int id)<br/>ID: " + id.ToString();

            var cat = HttpContext.Request.Params["cat"];
            if (cat != null)
                result += "CAT:" + cat;

            return result;
        }

        public string Action3(string cat, int id=1)
        {
            return "Action3(string cat, int id=1)<br/>CAT: " + (cat ?? "") + "\n" + "<br/>ID: " + id.ToString();
        }

        public string Action4(string catchall)
        {
            return "Action4(string catchall)<br/>Catch all:" + catchall;
        }
    }
}
