using System.Web.Http;

namespace PictureShop
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{id}",
                defaults: new {controller = "Rest", id = RouteParameter.Optional }
            );
        }
    }
}
