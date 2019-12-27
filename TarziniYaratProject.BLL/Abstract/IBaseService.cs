using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.BLL.Abstract
{
    public interface IBaseService<T>
            where T : IEntity
    {
        void Insert(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void Update(T entity);

        T Get(int entityID);

        ICollection<T> GetAll();
    }
}
