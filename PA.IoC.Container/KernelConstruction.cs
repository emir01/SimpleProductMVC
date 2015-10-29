using System;
using Ninject;
using Ninject.Web.Common;
using PA.IoC.Container.Modules;

namespace PA.IoC.Container
{
    public static class KernelConstruction
    {
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// 
        /// The parameter allows for WEB code to register web modules. If not provided
        /// allows for usage in integration/unit test.
        /// </summary>
        /// <returns>The created kernel.</returns>
        public static IKernel CreateKernel(Action<IKernel> bindWebModules = null)
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);

                // check if the optional web modules action is provided
                // if so call it and allow client code to register web related configurations
                if (bindWebModules != null)
                {
                    bindWebModules(kernel);
                }

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load(new DataAccessModule());
            kernel.Load(new BusinessLogicModule());
        }
    }
}
