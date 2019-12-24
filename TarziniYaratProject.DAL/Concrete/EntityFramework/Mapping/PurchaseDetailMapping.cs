using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class PurchaseDetailMapping : EntityTypeConfiguration<PurchaseDetail>
    {
        public PurchaseDetailMapping()
        {
            Property(a => a.Price)
                .HasColumnType("money");

        }
    }
}
