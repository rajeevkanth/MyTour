using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DataLayer.Initializer;
using MyTour.BootStrapper;
using MyTour.ControllerRegistry;
namespace MyTour
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Register();
            InitialiseDataBase();
            InitialiseDependencies();
        }

        private void  InitialiseDataBase()
        {
            Database.SetInitializer(new TourContextIntializer());
        }

        private void InitialiseDependencies()
        {
            MyTour.BootStrapper.BootStrapper.ConfigureDependencies();
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());
        }

        private void Register()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}