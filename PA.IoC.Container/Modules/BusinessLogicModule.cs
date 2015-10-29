using Ninject.Modules;
using Ninject.Web.Common;
using PA.Business.Interfaces;
using PA.Business.Logic;

namespace PA.IoC.Container.Modules
{
    class BusinessLogicModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>().InRequestScope();
        }
    }
}
