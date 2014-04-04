using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture05.Controllers;
using Lecture05.Models;
using Ninject;

namespace Lecture05.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null) return null;

    //        if (controllerType == typeof(IndexController)) return new IndexController(new DataBase());

            #region Рефлексия

            //return controllerType
            //    .GetConstructor(new [] { typeof(IDataBase) })
            //    .Invoke(new object[] { new DataBase() })
            //    as IController;


            #endregion

            #region Инжектор

            return kernel.Get(controllerType) as IController;
            
            #endregion

        }


        IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            kernel.Bind<IDataBase>().To<DataBase>();


        }
    }
}