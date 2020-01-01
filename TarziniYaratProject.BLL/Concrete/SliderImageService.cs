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
    public class SliderImageService : ISliderImageService
    {
        ISliderImageDAL _dal;
        public SliderImageService(ISliderImageDAL dal)
        {
            _dal = dal;
        }
        public void Delete(SliderImage entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public SliderImage Get(int entityID)
        {
            return _dal.Get(a => a.SliderImageID == entityID);
        }

        public ICollection<SliderImage> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(SliderImage entity)
        {
            _dal.Add(entity);
        }

        public void Update(SliderImage entity)
        {
            _dal.Update(entity);
        }
    }
}
