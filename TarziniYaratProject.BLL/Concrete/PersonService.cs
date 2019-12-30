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
    public class PersonService : IPersonService
    {
        IPersonDAL _dal;
        public PersonService(IPersonDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Person entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Person Get(int entityID)
        {
            return _dal.Get(a => a.PersonID == entityID);
        }

        public ICollection<Person> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Person entity)
        {
            _dal.Add(entity);
        }

        public void Update(Person entity)
        {
            _dal.Update(entity);
        }
    }
}
