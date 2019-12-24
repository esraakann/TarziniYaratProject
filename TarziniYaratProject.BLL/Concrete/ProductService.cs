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
    class ProductService : IProductService
    {
        IProductDAL _dal;
        public ProductService(IProductDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Product entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Product Get(int entityID)
        {
            return _dal.Get(a => a.ProductID == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Product entity)
        {
            _dal.Add(entity);
        }

        public void Update(Product entity)
        {
            _dal.Add(entity);
        }
    }
}
