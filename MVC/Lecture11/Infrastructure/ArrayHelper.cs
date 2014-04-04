using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
using System.Web.Mvc.Html;
using System.Reflection;

namespace Lecture11.Infrastructure
{
    public static class ArrayHelper
    {
        public static MvcHtmlString TextBoxForArray(this HtmlHelper helper, string name, int[] array)
        {
            var entry = "";
            if (array!=null) entry=array.Select(z=>z.ToString()).Aggregate((a,b)=>a+" "+b);
           return helper.TextBox(name,entry);
        }

        public static MvcHtmlString TextBoxForArray<TModel, TElement>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TElement[]>> address)
        {
            var name = ((address.Body as MemberExpression).Member as PropertyInfo).Name;
            var array = address.Compile()(helper.ViewData.Model);
            var entry = "";
            if (array != null) entry = array.Select(z => z.ToString()).Aggregate((a, b) => a + " " + b);
            return helper.TextBox(name, entry);
        }
    }
}