using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture04.Helpers
{
    public static class TodayHelper
    {
        public static string Today(this HtmlHelper html)
        {
            return @"<p align=""right""><i>Сегодня " + DateTime.Now.ToString("dd.MM.yyyy") + @"</i></p>";
        }

        #region

        public static MvcHtmlString Today1(this HtmlHelper html)
        {
            return new MvcHtmlString(@"<p align=""right""><i>Сегодня " + DateTime.Now.ToString("dd.MM.yyyy") + @"</i></p>");
        }

        public static MvcHtmlString Today2(this HtmlHelper html)
        {
            
            var i = new TagBuilder("i");
            i.SetInnerText("Сегодня " + DateTime.Now.ToString("dd.MM.yyyy"));
            
            var p = new TagBuilder("p");
            p.Attributes["align"] = "right";
            p.InnerHtml = i.ToString();

            return new MvcHtmlString(p.ToString());
        }

        #endregion
    }
}