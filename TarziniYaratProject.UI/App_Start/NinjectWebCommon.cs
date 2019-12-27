using WebActivatorEx;
using TarziniYaratProject.UI.App_Start;
[assembly: PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace TarziniYaratProject.UI.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using TarziniYaratProject.BLL.Abstract.EntityServices;
    using TarziniYaratProject.BLL.Concrete;
    using TarziniYaratProject.BLL.IoC.Ninject;

    public class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;  
            }
        }
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }


        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAddressService>().To<AddressService>();
            kernel.Bind<IBrandService>().To<BrandService>();
            kernel.Bind<ICargoStatusService>().To<CargoStatusService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<ICombineService>().To<CombineService>();
            kernel.Bind<ICommentService>().To<CommentService>();
            kernel.Bind<IImageService>().To<ImageService>();
            kernel.Bind<ILikeService>().To<LikeService>();
            kernel.Bind<IPersonService>().To<PersonService>();
            kernel.Bind<IProductDetailService>().To<ProductDetailService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IPurchaseDetailService>().To<PurchaseDetailService>();
            kernel.Bind<IPurchaseService>().To<PurchaseService>();

            kernel.Load<CustomDALModule>();
        }
    }
}