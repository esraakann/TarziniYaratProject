using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Purchase : IEntity
    {
        public Purchase()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        public int PurchaseID { get; set; }
        public int PersonID { get; set; }
        public decimal TotalPrice { get; set; }
        public int CargoStatusID { get; set; }

        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual CargoStatus CargoStatus { get; set; }
        public virtual Person Person { get; set; }

    }
}
