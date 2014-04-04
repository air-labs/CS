using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture10.Infrastructure;
using System.Web.UI.WebControls;

namespace Lecture10.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            return View();
        }

        [MyAuthorize]
        public string Secured()
        {
            return "Осуществлен доступ к странице авторизации";
        }

        //[HandleError(ExceptionType=typeof(NullReferenceException),View="SpecialError")]
       // [NullErrorHandler]
        public string Error()
        {
           // throw new Exception();
            throw new NullReferenceException();
        }

        [Profiler]
        public ViewResult Profile()
        {
            return View();
        }
        

    }
}
