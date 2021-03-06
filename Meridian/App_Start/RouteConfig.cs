using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Meridian
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute("ControllerRouter", "{controller}/{action}");
            routes.MapRoute("Default", "{*.}", new
            {
                controller = "Site",
                action = "Index"
            });
        }
    }
}
