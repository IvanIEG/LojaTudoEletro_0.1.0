using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.AutoMapper;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }
    }
}
