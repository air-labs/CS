using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;

namespace Lecture11.Infrastructure
{
    public class IntArrayModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var exists = bindingContext.ValueProvider.ContainsPrefix(bindingContext.ModelName);
            if (!exists) return null;
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            var text = value.AttemptedValue;
            try
            {
                return text.Split(' ').Select(z => int.Parse(z)).ToArray();
            }
            catch
            {
                return null;
            }
        }


    }
}