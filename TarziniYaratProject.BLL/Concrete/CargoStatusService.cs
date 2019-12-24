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
    class CargoStatusService : ICargoStatusService
    {
        ICargoStatusDAL _dal;
        public CargoStatusService(ICargoStatusDAL dal)
        {
            _dal = dal;
        }
        public void Delete(CargoStatus entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public CargoStatus Get(int entityID)
        {
            return _dal.Get(a => a.CargoStatusID == entityID);
        }

        public ICollection<CargoStatus> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(CargoStatus entity)
        {
            _dal.Add(entity);
        }

        public void Update(CargoStatus entity)
        {
            _dal.Update(entity);
        }
    }
}
