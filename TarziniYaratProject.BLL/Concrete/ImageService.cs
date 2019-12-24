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
    public class ImageService : IImageService
    {
        IImageDAL _dal;
        public ImageService(IImageDAL dal)
        {
            _dal = dal;
        }
        public void Delete(Image entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
             _dal.Delete(Get(id));
        }

        public Image Get(int entityID)
        {
            return _dal.Get(a => a.ImageID == entityID);
        }

        public ICollection<Image> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Image entity)
        {
            _dal.Add(entity);
        }

        public void Update(Image entity)
        {
            _dal.Add(entity);
        }
    }
}
