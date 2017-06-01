namespace TicketPortalApi
{
    using System.Reflection;
    using System.Web;
    using System.Web.Http;
    using Autofac;
    using Autofac.Integration.WebApi;
    using Repositories;
    using Services;

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            IContainer iocContainer = BuildIocContainer();

            HttpConfiguration httpConfiguration = GlobalConfiguration.Configuration;
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(iocContainer);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        private static IContainer BuildIocContainer()
        {
            var iocContainerBuilder = new ContainerBuilder();

            RegisterControllers(iocContainerBuilder);
            RegisterServices(iocContainerBuilder);

            var iocContainer = iocContainerBuilder.Build();
            return iocContainer;
        }

        private static void RegisterControllers(ContainerBuilder iocContainerBuilder)
        {
            iocContainerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }

        private static void RegisterServices(ContainerBuilder iocContainerBuilder)
        {
            iocContainerBuilder.RegisterType<TicketRepository>().As<ITicketRepository>().InstancePerRequest();
            iocContainerBuilder.RegisterType<TicketService>().As<ITicketService>().InstancePerRequest();
            iocContainerBuilder.RegisterType<TicketPortalDb>().InstancePerRequest();
        }
    }
}