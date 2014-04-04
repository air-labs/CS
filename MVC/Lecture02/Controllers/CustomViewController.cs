using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture01.Controllers
{
    public class CustomViewController : Controller
    {
        //
        // GET: /CustomView/

        public MyView CustomView()
        {
            return new MyView();
        }

        public MyRedirect CustomRedirect()
        {
            return new MyRedirect();
        }

    }

    public class MyView : ActionResult
    {

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Write(@"
<html>
<body>
Custom view
</body>
</html>");
        }

    }

    public class MyRedirect : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.RedirectPermanent("/CustomView/CustomView");
        }
    }
}
