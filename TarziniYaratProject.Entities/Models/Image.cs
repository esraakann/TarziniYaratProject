using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Image : IEntity
    {
        public int ImageID { get; set; }
        public string ImagePath { get; set; }
        public int ProductID { get; set; }
        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
        public virtual Product Product { get; set; }


    }
}
