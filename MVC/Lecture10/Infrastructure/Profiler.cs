using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace Lecture10.Infrastructure
{
    public class Profiler : ActionFilterAttribute
    {
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format("Start action {0} from controller {1}<br/>",
                filterContext.ActionDescriptor.ActionName,
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName));
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("End action<br/>");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Start rendering ");
            if (filterContext.Result is ViewResult)
                filterContext.HttpContext.Response.Write(
                    (filterContext.Result as ViewResult).ViewName);
            filterContext.HttpContext.Response.Write("<br/>");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("End rendering<br/>");
        }

    }
}
