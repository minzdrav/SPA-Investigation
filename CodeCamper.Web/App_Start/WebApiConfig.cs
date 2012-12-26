using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CodeCamper.Web
{
    public static class WebApiConfig
    {
        public static string ControllerOnly = "ApiControllerOnly";
        public static string ControllerAndId = "ApiControllerAndIntegerId";
        public static string ControllerAction = "ApiControllerAction";

        public static void Register(HttpConfiguration config)
        {
            var routes = config.Routes;

            routes.MapHttpRoute(
                name: ControllerOnly,
                routeTemplate: "api/{controller}"
                );

            routes.MapHttpRoute(
                name: ControllerAndId,
                routeTemplate: "api/{controller}/{id}",
                defaults: null, //defaults: new { id = RouteParameter.Optional } //,
                constraints: new {id = @"^\d+$"} // id must be all digits
                );

            routes.MapHttpRoute(
                name: ControllerAction,
                routeTemplate: "api/{controller}/{action}"
                );

            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            //config.EnableSystemDiagnosticsTracing();
        }
    }
}
