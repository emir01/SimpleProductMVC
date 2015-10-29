using PA.IoC.Container;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(PA.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(PA.Web.App_Start.NinjectWebCommon), "Stop")]

namespace PA.Web.App_Start
{
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Web.Common;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));

            // initialize using kernel construction, but also pass the action to register the IHttpModule
            // its done separatly to not mix HTTP Related stuff into Ninject Kernel, because of integration tests
            bootstrapper.Initialize(() =>
            {
                return KernelConstruction.CreateKernel(
                    kernel => kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>());
            });
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
    }
}
