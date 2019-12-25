using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    public class LikeMapping : EntityTypeConfiguration<Like>
    {
        public LikeMapping()
        {
            HasKey(a => a.LikeID);
            Property(a => a.CommentID)
                .IsOptional();
            Property(a => a.CombineID)
                .IsOptional();
            Property(a => a.ProductID)
                .IsOptional();
            

            HasRequired(a => a.Person)
                .WithMany(a => a.Likes)
                .HasForeignKey(a => a.PersonID)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Comment)
                .WithMany(a => a.Likes)
                .HasForeignKey(a => a.CommentID)
             .WillCascadeOnDelete(false);

            HasRequired(a => a.Combine)
                .WithMany(a => a.Likes)
                .HasForeignKey(a => a.CombineID)
             .WillCascadeOnDelete(false);

            HasRequired(a => a.Product)
                .WithMany(a => a.Likes)
                .HasForeignKey(a => a.ProductID)
             .WillCascadeOnDelete(false);
        }
    }
}
