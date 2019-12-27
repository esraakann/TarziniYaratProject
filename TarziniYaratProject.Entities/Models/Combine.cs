using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Combine : IEntity
    {
        public Combine()
        {
            Comments = new HashSet<Comment>();
        }

        public int CombineID { get; set; }
        public string Description { get; set; }
        public string CombineImage { get; set; }
        public int PersonID { get; set; }
        public int LikeCount { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Person Person { get; set; }
    }
}
