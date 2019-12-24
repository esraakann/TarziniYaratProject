using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class ProductDetailMapping : EntityTypeConfiguration<ProductDetail>
    {
        public ProductDetailMapping()
        {
            HasKey(a => a.ProductDetailID);
            Property(a => a.Size)
                .HasMaxLength(10)
                .IsRequired();

            Property(a => a.Stock)
                .IsRequired();
        }
    }
}
