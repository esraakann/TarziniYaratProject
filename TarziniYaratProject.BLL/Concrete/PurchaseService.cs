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
    public class PurchaseService : IPurchaseService
    {
        IPurchaseDAL _dal;
        public PurchaseService(IPurchaseDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Purchase entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Purchase Get(int entityID)
        {
            return _dal.Get(a => a.PurchaseID == entityID);
        }

        public ICollection<Purchase> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Purchase entity)
        {
            _dal.Add(entity);
        }

        public void Update(Purchase entity)
        {
            _dal.Update(entity);
        }
    }
}
