namespace TarziniYaratProject.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TarziniYaratProject.Entities.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TarziniYaratProject.DAL.Concrete.EntityFramework.TarziniYaratDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }



        protected override void Seed(TarziniYaratProject.DAL.Concrete.EntityFramework.TarziniYaratDBContext context)
        {

            //SliderImage = new SliderImage();

            //List<Brand> brands = new List<Brand>()
            //{
            //  new Brand { Name = "Nike",BrandID =1},
            //  new Brand { Name = "Adidas" ,BrandID = 2},
            //  new Brand { Name = "Puma",BrandID = 3}

            //};

            //List<Category> categories = new List<Category>()
            //{
            //    new Category { CategoryID  =1, Name ="Pantolon", Decription = ""},
            //    new Category { CategoryID  =2, Name ="Ceket", Decription = ""},
            //    new Category { CategoryID  =3, Name ="Gömlek", Decription = ""}
            //};


            //List<CargoStatus> cargoStatuses = new List<CargoStatus>()
            //{
            //    new CargoStatus {  CargoStatusID  =1, Name ="Hazırlanıyor"},
            //    new CargoStatus {  CargoStatusID  =2, Name ="Kargoya Verildi"},
            //    new CargoStatus {  CargoStatusID  =3, Name ="Adrese ulaştı"}

            //};

            //Person person = new Person();
            //person.PersonID = 1;
            //person.FirstName = "Fatih";
            //person.Surname = "Karademir";
            //person.IsActive = true;
            //person.Username = "fatihk";
            //person.Password = "12345";
            //person.CellPhone = "4562523523523";
            //person.PersonType = PersonType.Admin;
            //person.Email = "fatihkrdmr24@gmail.com";
            //person.Gender = "E";
            //person.Addresses.Add(
            //new Address { AddressID = 1, Country = "Turkey", PostCode = 34000, FullAddress = "Istanbul", IsActiveAddress = true, Distrinct = "Kagıthane", Province = "Ist", PersonID = 1 });

            //Person person2 = new Person
            //{
            //    PersonID = 2,
            //    FirstName = "Mustafa",
            //    Surname = "Akçakaya",
            //    CellPhone = "1234567891011",
            //    IsActive = true,
            //    Username = "mstfa",
            //    Password = "sifre123",
            //    PersonType = PersonType.Member,
            //    Email = "mustafaakcakaya@gmail.com",
            //    Gender = "E",
            //    Addresses = new List<Address>() { new Address { PersonID = 2, AddressID = 2, Country = "Turkey", Distrinct = "Bakirköy", Province = "Istanbul", PostCode = 34293, FullAddress = "string mah. char sk. no:15", IsActiveAddress = true } }
            //};

            //List<Product> products = new List<Product>()
            //{

            //    new Product
            //    {
            //        ProductID=1,
            //        BrandID=1,
            //        Gender="E",
            //        CategoryID=3,
            //        Description="Kumaşı yün",
            //        Title="Beyaz V Yakalı Gömlek ",
            //        Price=40,
            //        Images = new List<Image>(){ new Image { ImageID = 2, ImagePath = "dfgdfgd", ProductID = 1} },
            //        CreatedDate=DateTime.Now,
            //        Discount=0,
            //        ProductDetails=new List<ProductDetail>()
            //        {
            //           new ProductDetail{ ProductDetailID=1, Size="M", Color=ProductDetail.ProductColor.Beyaz, Stock=4 }
            //        }
            //    },

            //    new Product
            //    {
            //        ProductID=2,
            //        BrandID=3,
            //        CategoryID=2,
            //        Gender="E",
            //        Description="Pamuklu",
            //        Title="Kırmızı manşetli ceket",
            //        Price=80,
            //         Images = new List<Image> ()
            //         {
            //             new Image { ImageID = 1, ImagePath = "dgdfgdf", ProductID = 2}
            //         },
            //        CreatedDate=DateTime.Now,
            //        Discount=0 ,
            //         ProductDetails=new List<ProductDetail>()
            //         {
            //           new ProductDetail{ ProductDetailID=2, Size="S", Color=ProductDetail.ProductColor.Kırmızı, Stock=7 }
            //         }
            //    },

            //    new Product
            //    {
            //        ProductID=3,
            //        BrandID=1,
            //        CategoryID=1,
            //        Description="Saten",
            //        Gender="E",
            //        Title="Saten Pantolon",
            //        Price=60,
            //        CreatedDate=DateTime.Now,
            //        Discount=0,
            //        Images = new List<Image>(){ new Image { ImageID = 5, ImagePath = "fwemfwmfw", ProductID = 3} },
            //        ProductDetails=new List<ProductDetail>()
            //        {
            //           new ProductDetail{ ProductDetailID=3, Size="36", Color=ProductDetail.ProductColor.Siyah, Stock=3 }
            //        }
            //    },

            //    new Product
            //    {
            //        ProductID=4,
            //        BrandID=2,
            //        CategoryID=3,
            //        Gender="E",
            //        Description="İpek",
            //        Title="İpek Gömlek",
            //        Price=130,
            //        CreatedDate=DateTime.Now,
            //        Discount=0,
            //          ProductDetails=new List<ProductDetail>()
            //          {
            //           new ProductDetail{ ProductDetailID=4, Size="L", Color=ProductDetail.ProductColor.Yeşil, Stock=7 }
            //          }
            //    }

            //};

            //List<Combine> combines = new List<Combine>()
            //{
            //    new Combine
            //    {
            //        CombineID = 1,
            //        Description="Günlük tarz",
            //        CombineImage = "imageyolu",
            //        PersonID=2,
            //        CommentCount=50,
            //        Likes = new List<Like>(),//{ new Like { LikeID=1, PersonID=2, CombineID=1, ProductID=0, CommentID=0 } },
            //        Comments = new List<Comment>()/*{ new Comment { CombineID=1,  ProductID= 0, CommentID=1, CommentDate=DateTime.Now, Content="Ooo çok güzel bir kombinmiş", PersonID=1,IsActive=true }, }*/
            //    }
            //};

            //Purchase purchase = new Purchase()
            //{
            //    PurchaseID = 1,
            //    PersonID = 1,
            //    TotalPrice = 140,
            //    CargoStatusID = 1,
            //    PurchaseDetails = new List<PurchaseDetail>()
            //    {
            //      new PurchaseDetail
            //      {
            //            PurchaseDetailID=1,
            //            ProductID=2,
            //            Count=1,
            //            PurchaseID=1,
            //            Price=80
            //      },
            //      new PurchaseDetail
            //      {
            //            PurchaseDetailID=2,
            //            ProductID=3,
            //            Count=1,
            //            PurchaseID=1,
            //            Price=60
            //      }

            //    }

            //};
            //context.Brand.AddRange(brands);
            //context.Category.AddRange(categories);
            //context.CargoStatus.AddRange(cargoStatuses);
            //context.Person.Add(person);
            //context.Person.Add(person2);
            //context.Product.AddRange(products);
            //context.Combine.AddRange(combines);
            //context.Purchase.Add(purchase);

            //context.SaveChanges();

            //base.Seed(context);
        }
        //This method will be called after migrating to the latest version.

        //You can use the DbSet<T>.AddOrUpdate() helper extension method
        //      to avoid creating duplicate seed data.


    }
}
