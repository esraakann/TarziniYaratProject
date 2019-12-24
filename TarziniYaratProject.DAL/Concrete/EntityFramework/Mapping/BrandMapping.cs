using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class BrandMapping : EntityTypeConfiguration<Brand>
    {
        public BrandMapping()
        {
            HasKey(a => a.BrandID);

            HasMany(a => a.Products)
            .WithRequired(a => a.Brand)
            .HasForeignKey(a => a.BrandID);
            //.WillCascadeOnDelete(false);//TODO: Control Et(WillCascade)

            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
