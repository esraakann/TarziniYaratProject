using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class PurchaseDetail : IEntity
    {
        //TODO: primary keyi olmayan yarı sanal bir tablo olduğu için migration'ları oluştururken primary key isteyebilir.
        public PurchaseDetail()
        {

        }

        public int PurchaseDetailID { get; set; }
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }

    }
}
