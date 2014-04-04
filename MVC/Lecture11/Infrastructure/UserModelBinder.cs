using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture11.Models;

namespace Lecture11.Infrastructure
{
    public class UserModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var name = controllerContext.HttpContext.User.Identity.Name;
            if (string.IsNullOrEmpty(name)) return new User { Name = "guest", IsAdmin = false };
            else return new User { Name = name, IsAdmin = false };
        }

    
    }
}