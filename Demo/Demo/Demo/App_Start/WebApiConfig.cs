using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Demo
{
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Cấu hình các route
            config.MapHttpAttributeRoutes(); // Nếu bạn muốn dùng attribute routing

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

