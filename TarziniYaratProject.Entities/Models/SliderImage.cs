using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class SliderImage:IEntity
    {
        public int SliderImageID { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }


    }
}
