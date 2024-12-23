using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductAppDem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "PFive",
                url: "",
                defaults: new { controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "PFour",
                url: "Product",
                defaults: new { controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "PThree",
                url: "Product/NewProduct",
                defaults: new { controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "PTwo",
                url: "Product/CreateProduct",
                defaults: new { controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "POne",
              url: "Product/SaveProduct",
              defaults: new { controller = "Product", action = "AddProduct", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
