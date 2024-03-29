﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.DAL.Abstract;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.BLL.Concrete
{
    public class LikeService : ILikeService
    {
        ILikeDAL _dal;
        public LikeService(ILikeDAL dal)
        {
            _dal = dal;
        }

        public void Delete(Like entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Like Get(int entityID)
        {
            return _dal.Get(a => a.LikeID == entityID);
        }

        public ICollection<Like> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Like entity)
        {
            _dal.Add(entity);
        }

        public void Update(Like entity)
        {
            _dal.Update(entity);
        }
    }
}
