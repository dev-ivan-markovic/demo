using Microsoft.Practices.Unity;
using System.Web.Http;
using Project_Beer.Service;
using Unity.WebApi;

namespace Project_Beer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IBeerService, BeerService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}