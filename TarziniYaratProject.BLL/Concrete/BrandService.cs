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
    class BrandService : IBrandService
    {
        IBrandDAL _dal;
        public BrandService(IBrandDAL dal)
        {
            _dal = dal;
        }

        public void Delete(Brand entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Brand Get(int entityID)
        {
           return _dal.Get(a=>a.BrandID==entityID);
        }

        public ICollection<Brand> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Brand entity)
        {
            _dal.Add(entity);
        }

        public void Update(Brand entity)
        {
            _dal.Update(entity);
        }
    }
}
