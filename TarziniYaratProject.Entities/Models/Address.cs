using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Address:IEntity
    {
        public int AddressID { get; set; }
        public int PersonID { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Distrinct { get; set; }
        public string FullAddress { get; set; }
        public int PostCode { get; set; }
        public bool IsActiveAddress { get; set; } 

        public virtual Person Person { get; set; }  
        

    }
}
