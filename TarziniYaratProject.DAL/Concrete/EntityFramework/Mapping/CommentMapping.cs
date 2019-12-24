using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            HasKey(a => a.CommentID);
            //CombineMapping içerisinde tanımlandı.
            //HasRequired(a => a.Combine)
            //    .WithMany(a => a.Comments)
            //    .HasForeignKey(a => a.PersonID)
            //    .WillCascadeOnDelete(false);

            HasRequired(a => a.Product)
                .WithMany(a => a.Comments)
                .HasForeignKey(a => a.ProductID);



            Property(a => a.Content)
                .HasMaxLength(250)
                .IsRequired();

            Property(a => a.CommentDate)
                .HasColumnType("date")
                .IsRequired();

            

        }
    }
}
