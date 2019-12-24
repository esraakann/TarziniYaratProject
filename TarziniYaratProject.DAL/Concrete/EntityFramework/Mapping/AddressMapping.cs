using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    public class AddressMapping:EntityTypeConfiguration<Address>
    {
        public AddressMapping()
        {
            HasKey(a => a.AddressID);

            HasRequired(a => a.Person)
               .WithMany(a => a.Addresses)
               .HasForeignKey(a => a.PersonID)
               .WillCascadeOnDelete(false);

            Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(30);


            Property(a => a.Province)
                .IsRequired()
                .HasMaxLength(30);

            Property(a => a.FullAddress)
                .IsRequired()
                .HasMaxLength(300);

            Property(a => a.Distrinct)
             .IsRequired()
             .HasMaxLength(30);

        }
    }
}
