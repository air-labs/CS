using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture11.Models;

namespace Lecture11.Infrastructure
{
    public class EmployeeModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Employee emp = (bindingContext.Model as Employee)?? new Employee();

            var value = bindingContext.ValueProvider.GetValue("Name");
            if (value != null)
            {
                var parts = value.AttemptedValue.Split(' ');
                if (parts.Length > 0)
                    emp.FirstName = parts[0];
                if (parts.Length > 1)
                    emp.LastName = parts[1];
            }

            value = bindingContext.ValueProvider.GetValue("IsManager");
            if (value!=null)
                emp.IsManager=(bool)value.ConvertTo(typeof(bool));

            return emp;
        }

    
    }
}