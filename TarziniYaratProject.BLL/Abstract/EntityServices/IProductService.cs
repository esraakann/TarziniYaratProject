using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.BLL.Abstract.EntityServices
{
    public interface IProductService : IBaseService<Product>
    {
       ICollection<Product> GetProductsByCatID(int catID);
    }
}
