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
    class PurchaseDetailService : IPurchaseDetailService
    {
        IPurchaseDetailDAL _dal;
        public PurchaseDetailService(IPurchaseDetailDAL dal)
        {
            _dal = dal;
        }
        public void Delete(PurchaseDetail entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public PurchaseDetail Get(int entityID)
        {
            return _dal.Get(a => a.PurchaseDetailID == entityID);
        }

        public ICollection<PurchaseDetail> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(PurchaseDetail entity)
        {
            _dal.Add(entity);
        }

        public void Update(PurchaseDetail entity)
        {
            _dal.Update(entity);
        }
    }
}
