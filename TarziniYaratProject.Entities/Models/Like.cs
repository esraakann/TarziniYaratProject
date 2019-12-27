using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Like :IEntity
    {
        public int LikeID { get; set; }
        public int PersonID { get; set; }
        public int CommentID { get; set; }
        public int ProductID { get; set; }
        public int CombineID { get; set; }

        public virtual Person Person { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Product Product { get; set; }
        public virtual Combine Combine { get; set; }
    }
}
