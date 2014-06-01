using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Lecture09.Controllers
{
    public class JQueryController : Controller
    {
        //
        // GET: /JQuery/

        public ActionResult Index()
        {
            return View("Index3");
        }

        public string AjaxAction()
        {
            return "<tr><td>Test</td></tr>";
        }

        public string GetRooms(string floor)
        {
            var result= Enumerable.Range(0, 10).Select(z => "<option> " + floor + z.ToString()).Aggregate((a, b) => a + " " + b);
            return result;
        }

        //public string GetRoomsJson(string floor)
        //{
        //    var result = Enumerable.Range(0, 10).Select(z => floor + z.ToString()).ToArray();
        //    return new JavaScriptSerializer(result);
        //}

    }

}
