using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class ImageMapping : EntityTypeConfiguration<Image>
    {
        public ImageMapping()
        {
            HasKey(a=>a.ImageID);

            HasRequired(a => a.Product)
                .WithMany(a => a.Images)
                .HasForeignKey(a => a.ProductID);

            Property(a => a.ImagePath)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
