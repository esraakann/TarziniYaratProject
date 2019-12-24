using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasKey(a => a.CategoryID);

            HasMany(a => a.Products)
               .WithRequired(a => a.Category)
               .HasForeignKey(a => a.CategoryID)
               .WillCascadeOnDelete(false);

            Property(a => a.Name)
               .HasMaxLength(50)
               .IsRequired();

            Property(a => a.Decription)
               .HasMaxLength(50)
               .IsRequired();
        }
    }
}
