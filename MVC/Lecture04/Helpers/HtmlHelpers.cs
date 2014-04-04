using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture03.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString Route(this HtmlHelper html, string route)
        {
            return new MvcHtmlString("<a href=\"" + route + "\">" + route + "</a><br>");
        }
    }
}