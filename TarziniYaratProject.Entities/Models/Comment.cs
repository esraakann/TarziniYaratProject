using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Comment : IEntity
    {
        public Comment()
        {
            Likes = new HashSet<Like>();
        }
        public int CommentID { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
        public int CombineID { get; set; }
        public int ProductID { get; set; }
        public bool IsActive { get; set; }

        public virtual Product Product { get; set; } //should be nullable
        public virtual Combine Combine { get; set; } //should be nullable
        public virtual Person Person { get; set; }
        public virtual ICollection<Like> Likes { get; set; }


    }
}
