using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.DataAccess.EntityFramework;
using TarziniYaratProject.DAL.Abstract;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.DAL
{
    public class PersonDAL : EFRepositoryBase<Person, TarziniYaratDBContext>, IPersonDAL
    {
        public PersonDAL()
        {
           
        }
    }
}
