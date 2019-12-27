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
    public  class CombineService : ICombineService
    {
        ICombineDAL _dal;
        public CombineService(ICombineDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Combine entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Combine Get(int entityID)
        {
            return _dal.Get(a => a.CombineID == entityID);
        }

        public ICollection<Combine> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Combine entity)
        {
            _dal.Add(entity);
        }

        public void Update(Combine entity)
        {
            _dal.Update(entity);
        }
    }
}
