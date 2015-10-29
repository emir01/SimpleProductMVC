using System.Data.Entity;
using Ninject.Modules;
using Ninject.Web.Common;
using PA.Data.Access.Repositories;
using PA.Data.Interfaces;
using PA.DataModel.Context;

namespace PA.IoC.Container.Modules
{
    class DataAccessModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<DbContext>().To<ShopContext>().InRequestScope();

            Bind<IProductRepository>().To<ProductRepository>().InRequestScope();
        }
    }
}
