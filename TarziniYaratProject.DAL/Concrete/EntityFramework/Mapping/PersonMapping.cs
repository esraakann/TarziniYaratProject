using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class PersonMapping : EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            HasKey(a => a.PersonID);

            Property(a => a.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Surname)
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Username)
                .HasMaxLength(50)
                .IsRequired();


            Property(a => a.Password)
                 .HasMaxLength(50)
                 .IsRequired();


            Property(a => a.PersonType)
                .IsRequired();

            Property(a => a.IsActive)
                .HasColumnType("bit")
                .IsRequired();

            Property(a => a.Email)
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.CellPhone)
                .HasColumnType("char")
                .HasMaxLength(13)
                .IsRequired();

            Property(a => a.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .HasColumnType("char");

            HasMany(a => a.Comments)
                .WithRequired(a => a.Person)
                .HasForeignKey(a => a.PersonID);

           




        }
    }
}
