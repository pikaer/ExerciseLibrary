using EFDAL;
using NCode.Composition.DisposableParts;
using System;
using System.ComponentModel.Composition.Hosting;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace ExerciseLibrary
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DirectoryCatalog catalog = new DirectoryCatalog(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
            MefDependencyResolver res = new MefDependencyResolver(new DisposableWrapperCatalog(catalog, true));
            DependencyResolver.SetResolver(res);
            //MiniProfilerEF6.Initialize();
            //ApplicationService.Initialize();
            DatabaseInitializer.Initialize();

        }
    }
}
