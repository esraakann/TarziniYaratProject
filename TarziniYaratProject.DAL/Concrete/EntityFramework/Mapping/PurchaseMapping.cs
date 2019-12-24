using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class PurchaseMapping : EntityTypeConfiguration<Purchase>
    {
        public PurchaseMapping()
        {
            HasKey(a => a.PurchaseID);

            HasMany(a => a.PurchaseDetails)
                .WithRequired(a => a.Purchase)
                .HasForeignKey(a => a.PurchaseID);

            HasRequired(a => a.Person)
                .WithMany(a => a.Purchases)
                .HasForeignKey(a => a.PersonID);

            Property(a => a.TotalPrice)
                .HasColumnName("money");
        }
    }
}
