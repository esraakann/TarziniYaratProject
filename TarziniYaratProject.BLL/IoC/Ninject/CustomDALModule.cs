using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.DAL.Abstract;
using TarziniYaratProject.DAL.Concrete.EntityFramework.DAL;

namespace TarziniYaratProject.BLL.IoC.Ninject
{
    class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdressDAL>().To<AdressDAL>();
            Bind<IBrandDAL>().To<BrandDAL>();
            Bind<ICargoStatusDAL>().To<CargoStatusDAL>();
            Bind<ICategoryDAL>().To<CategoryDAL>();
            Bind<ICombineDAL>().To<CombineDAL>();
            Bind<ICommentDAL>().To<CommentDAL>();
            Bind<IImageDAL>().To<ImageDAL>();
            Bind<IPersonDAL>().To<PersonDAL>();
            Bind<IProductDAL>().To<ProductDAL>();
            Bind<IProductDetailDAL>().To<ProductDetailDAL>();
            Bind<IPurchaseDAL>().To<PurchaseDAL>();
            Bind<IPurchaseDetailDAL>().To<PurchaseDetailDAL>();
            
        }
    }
}
