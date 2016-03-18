using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "OrderApi",
                routeTemplate: "api/orders/{id}",
                defaults: new { controller="Orders", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProductsApi",
                routeTemplate: "api/products/{id}",
                defaults: new { controller = "Products", id = RouteParameter.Optional }
            );
        }
    }
}
