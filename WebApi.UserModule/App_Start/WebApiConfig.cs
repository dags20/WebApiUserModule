using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.UserModule
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //TODO: This should only give access to my api. for security reasons
            // Enable CORS
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}