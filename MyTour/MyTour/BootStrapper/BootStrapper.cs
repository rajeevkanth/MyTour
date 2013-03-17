using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;
using ProviderLayer.Interface;
using ProviderLayer.Implementation;
using DataLayer;

namespace MyTour.BootStrapper
{
    public class BootStrapper
    {
        public static void ConfigureDependencies()
        {
            ObjectFactory.Initialize(x => x.AddRegistry<ControllerRegistry>());
        }
    }

    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            For<ITourProvider>().Use<TourProvider>();
            ForConcreteType<MyTourContext>();   
        }
    }

}