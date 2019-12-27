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
    public class AddressService : IAddressService
    {
        IAdressDAL _dal;
        public AddressService(IAdressDAL dal)
        {
            _dal = dal;
        }

        public void Delete(Address entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Address Get(int entityID)
        {
             return _dal.Get(a=>a.AddressID==entityID);
        }

        public ICollection<Address> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Address entity)
        {
            _dal.Add(entity);
        }

        public void Update(Address entity)
        {
            _dal.Update(entity);
        }
    }
}
