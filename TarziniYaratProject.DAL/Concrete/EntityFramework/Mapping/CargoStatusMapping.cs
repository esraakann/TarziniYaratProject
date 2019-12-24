using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping
{
    class CargoStatusMapping : EntityTypeConfiguration<CargoStatus>
    {
        public CargoStatusMapping()
        {
            HasKey(a=>a.CargoStatusID);

            HasMany(a => a.Purchases)
            .WithRequired(a => a.CargoStatus)
            .HasForeignKey(a => a.CargoStatusID);


            Property(a => a.Name)
                 .IsRequired()
                .HasMaxLength(50);
               
        }
    }
}
