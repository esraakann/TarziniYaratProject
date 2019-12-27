using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.DAL.Abstract;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.BLL.Concrete
{
    public class ProductDetailService : IProductDetailService
    {
        IProductDetailDAL _dal;
        public ProductDetailService(IProductDetailDAL dal)
        {
            _dal = dal;
        }
        public void Delete(ProductDetail entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public ProductDetail Get(int entityID)
        {
            return _dal.Get(a => a.ProductDetailID == entityID);
        }

        public ICollection<ProductDetail> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(ProductDetail entity)
        {
            _dal.Add(entity);
        }

        public void Update(ProductDetail entity)
        {
            _dal.Add(entity);
        }
    }
}
