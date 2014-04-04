using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lecture03
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Route5",
                "Route5/{*catchall}",
                new { controller = "My", action = "Action4" });

            routes.MapRoute(
                "Route4",
                "Route4/{controller}/{action}/{id}",
                new { controller = "My", action = "Action3",
                    id=UrlParameter.Optional
                });
              

            routes.MapRoute(
                "Route3",
                "Route3/{controller}/{action}/Id{id}",
                new { controller = "My", action = "Action3", id = 1 },
                new { id = @"^\d*$" });

            routes.MapRoute(
                "Route2",
                "Route2/{controller}/{action}/{id}",
                new { controller="My", action="Action3", id=1 });

            routes.MapRoute(
                "Route1",
                "Route1",
                new { controller = "My", action = "Action1" });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}", // URL with parameters
                new { controller = "Index", action = "Index" }); // Parameter defaults

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}