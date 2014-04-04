using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture01.Controllers
{
    public class CustomController : IController
    {
        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            if (requestContext.RouteData.Values["action"] == "Index")
            {
                requestContext.HttpContext.Response.Write("<html><body>Custom controller</body></html>");
            }
            else
            {
                new FileContentResult(
                System.Text.Encoding.UTF8.GetBytes("Hello, file!"),
                "bin/bin").ExecuteResult(new ControllerContext { RequestContext = requestContext });
            }
        }
    }
}
