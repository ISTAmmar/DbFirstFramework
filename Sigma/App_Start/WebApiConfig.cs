using System.Web.Http;
using Implementation.Services;
using Interfaces.Services;
using Microsoft.Practices.Unity;

namespace Sigma
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IDashboardService, DashboardService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityApiControllerResolver(container);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}