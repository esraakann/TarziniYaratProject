using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.DAL.Concrete.EntityFramework
{
    class TarziniYaratInitializer:CreateDatabaseIfNotExists<TarziniYaratDBContext>
    {
        protected override void Seed(TarziniYaratDBContext context)
        {
            //TODO: Başlangıçta eklenmesi istenen yapılar buraya yazılabilir.
            List<Brand> brands = new List<Brand>()
            {
              new Brand { Name = "Nike",BrandID =1},
              new Brand { Name = "Adidas" ,BrandID = 2},
              new Brand { Name = "Puma",BrandID = 3}
              
            };

            List<Category> categories = new List<Category>()
            {
                new Category { CategoryID  =1 , Name ="Pantolon", Decription = ""},
                new Category { CategoryID  =2 , Name ="Ceket", Decription = ""},
                new Category { CategoryID  =3 , Name ="Gömlek", Decription = ""}
            };


            List<CargoStatus> cargoStatuses = new List<CargoStatus>()
            {
                new CargoStatus {  CargoStatusID  =1 , Name ="Hazırlanıyor"},
                new CargoStatus {  CargoStatusID  =1 , Name ="Kargoya Verildi"},
                new CargoStatus {  CargoStatusID  =1 , Name ="Adrese ulaştı"}
              
            };

            Person person = new Person();
            person.FirstName = "Fatih";
            person.Surname = "Karademir";
            person.IsActive = true;
            person.Username = "fatihk";
            person.Password = "12345";
            person.Email = "fatihkrdmr24@gmail.com";
            person.Gender = "1";
            person.Addresses.Add(
                new Address { AddressID = 1, Country = "Turkey", PostCode = 34000, FullAddress = "Istanbul", IsActiveAddress = true, Distrinct = "Kagıthane", Province = "Ist" }
            );



            //kişiden sonra
            List<Image> images = new List<Image>()
            {
                new Image { ImageID = 1, ImagePath="", }
            }; 


          
            
            base.Seed(context);
        }
    }
}
