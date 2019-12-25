using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class CombineMapping : EntityTypeConfiguration<Combine>
    {
        public CombineMapping()
        {
            HasKey(a=>a.CombineID);
            
            HasMany(a => a.Comments)
                .WithRequired(a => a.Combine)
                .HasForeignKey(a => a.CombineID)
                .WillCascadeOnDelete(false);

           
            HasRequired(a => a.Person)
                .WithMany(a => a.Combines)
                .HasForeignKey(a => a.PersonID)
                .WillCascadeOnDelete(false);

            Property(a => a.Description)
                .HasMaxLength(750);

            Property(a => a.CombineImage)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
