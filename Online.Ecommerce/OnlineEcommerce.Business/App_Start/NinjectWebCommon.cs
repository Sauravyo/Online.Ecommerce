
using Online.Ecommerce.InversionOfControl;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(OnlineEcommerce.Business.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(OnlineEcommerce.Business.App_Start.NinjectWebCommon), "Stop")]




namespace OnlineEcommerce.Business.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Online.Ecommerce.Data.Repositories;
    using Online.Ecommerce.Entity.IRepository;
    using OnlineEcommerce.BusinessLayer;
    using OnlineEcommerce.BusinessLayer.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    //using Online.Ecommerce.Data.Repositories;
    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            //var ioc = new IOC();
            //var kernel = ioc.Kernel;
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                //ioc.GetNinjectModules();
                kernel.Bind<IItemRepository>().To<ItemRepository>();
                kernel.Bind<IItemService>().To<ItemService>();
                kernel.Bind<ICustomerRepository>().To<CustomerRepository>();
                kernel.Bind<ICustomerService>().To<CustomerService>();
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
        }
    }
}
