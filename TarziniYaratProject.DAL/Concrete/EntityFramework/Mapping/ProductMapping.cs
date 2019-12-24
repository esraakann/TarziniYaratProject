using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(a => a.ProductID);

            HasMany(a => a.PurchaseDetails)
                .WithRequired(a => a.Product)
                .HasForeignKey(a => a.ProductID);

            Property(a => a.Description)
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Title)
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Price)
                .HasColumnType("money");
        }
    }
}
