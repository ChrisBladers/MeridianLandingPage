using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Container = SimpleInjector.Container;

namespace Meridian
{
    public class ContainerConfig
    {
        public static void RegisterContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            var assembly = Assembly.GetExecutingAssembly();
            var registrations = assembly.GetExportedTypes().Where(type => type.Namespace != null && (type.Namespace.StartsWith("Meridian.Services")
                                                                                                        || type.Namespace.StartsWith("Meridian.Services.Interfaces")
                                                                                                        || type.Namespace.StartsWith("Meridian.Handlers")
                                                                                                        || type.Namespace.StartsWith("Meridian.Handlers.Interfaces")
                                                                                                        || type.Namespace.StartsWith("Meridian.Repositories")
                                                                                                        || type.Namespace.StartsWith("Meridian.Repositories.Interfaces")))
                .SelectMany(type => type.GetInterfaces(), (type, service) => new { service, implementation = type });

            foreach (var reg in registrations)
            {
                container.Register(reg.service, reg.implementation);
            }
            container.RegisterMvcControllers(assembly);
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}