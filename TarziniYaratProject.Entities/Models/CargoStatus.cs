using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class CargoStatus : IEntity
    {
        public CargoStatus()
        {
            Purchases = new HashSet<Purchase>();
        }
        public int CargoStatusID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
