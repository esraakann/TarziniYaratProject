using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.DAL.Concrete.EntityFramework.Mapping;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework
{
    public class TarziniYaratDBContext : DbContext
    {
        //@"Server=DESKTOP-781S50N\MSSQLSERVER2; Database = TarziniYaratDb; uid=sa; pwd = 123" ESRA
        //
        public TarziniYaratDBContext() : base(@"Server=EMRE\SQLEXPRESS; Database = TarziniYaratDb; uid=sa; pwd = 123")
        {

        }


        #region DB Set Tables
        public DbSet<Address> Adress { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<CargoStatus> CargoStatus { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Combine> Combine { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Like> Like { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Bu classlardan etkileşim aldığımı belirttiğim bölüm
            //Mapping isimleri burada yazdığım şekilde isimlendirin
            //TODO: Mapping(klasörü) EntityFramework'ün olduğundan o klasörde olmalı!
            #region Configurations
            modelBuilder.Configurations.Add(new AddressMapping());
            modelBuilder.Configurations.Add(new BrandMapping());
            modelBuilder.Configurations.Add(new CargoStatusMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new CombineMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new ImageMapping());
            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new ProductDetailMapping());
            modelBuilder.Configurations.Add(new PurchaseMapping());
            modelBuilder.Configurations.Add(new PurchaseDetailMapping());
            modelBuilder.Configurations.Add(new LikeMapping());
            #endregion

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
