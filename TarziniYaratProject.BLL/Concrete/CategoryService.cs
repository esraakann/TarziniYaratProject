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
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _dal;
        public CategoryService(ICategoryDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Category entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Category Get(int entityID)
        {
            return _dal.Get(a => a.CategoryID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Category entity)
        {
            _dal.Add(entity);
        }

        public void Update(Category entity)
        {
            _dal.Update(entity);
        }
    }
}
