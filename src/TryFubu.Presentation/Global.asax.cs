using System.Web.Routing;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using FubuMVC.StructureMap.Bootstrap;
using TryFubu.Presentation.Configuration;
using TryFubu.Presentation.Services;
using StructureMap;

namespace TryFubu.Presentation
{
    public class Global : FubuStructureMapApplication
    {
        protected void Application_Start()
        {
            FubuApplication
                .For<TryFubuRegistry>()
                .StructureMap(() => new Container(x => x.For<IHttpSession>().Use<CurrentHttpContextSession>()))
                .Bootstrap(RouteTable.Routes);
        }
    }
}