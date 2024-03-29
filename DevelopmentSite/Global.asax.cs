using System.Web.Optimization;
using System.Web.Routing;

using Kentico.Web.Mvc;

namespace Kentico.AspNet.Mvc.DevelopmentSite
{
    public class KenticoDevelopmentSiteMvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Enables and configures selected Kentico ASP.NET MVC integration features
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            // Registers routes including system routes for enabled features
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Registers enabled bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
