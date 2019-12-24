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
    class CommentService : ICommentService
    {
        ICommentDAL _dal;
        public CommentService(ICommentDAL dal)
        {
            _dal = dal;
        }

        public void Delete(Comment entity)
        {
            _dal.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _dal.Delete(Get(id));
        }

        public Comment Get(int entityID)
        {
            return _dal.Get(a => a.CommentID == entityID);
        }

        public ICollection<Comment> GetAll()
        {
            return _dal.GetAll();
        }

        public void Insert(Comment entity)
        {
            _dal.Add(entity);
        }

        public void Update(Comment entity)
        {
            _dal.Update(entity);
        }
    }
}
