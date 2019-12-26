using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{
    public class AdminProcessesController : Controller
    {
        // GET: Admin/AdminProcesses
        public ActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            {

                new Product
                {
                    ProductID=1,
                    BrandID=1,
                    Gender="E",
                    CategoryID=3,
                    Description="Kumaşı yün",
                    Title="Beyaz V Yakalı Gömlek ",
                    Price=40,
                    Images = new List<Image>(){ new Image { ImageID = 2, ImagePath = "dfgdfgd", ProductID = 1} },
                    CreatedDate=DateTime.Now,
                    Discount=0,
                    ProductDetails=new List<ProductDetail>()
                    {
                       new ProductDetail{ ProductDetailID=1, Size="M", Color=ProductDetail.ProductColor.Beyaz, Stock=4 }
                    }
                },

                new Product
                {
                    ProductID=2,
                    BrandID=3,
                    CategoryID=2,
                    Gender="E",
                    Description="Pamuklu",
                    Title="Kırmızı manşetli ceket",
                    Price=80,
                     Images = new List<Image> ()
                     {
                         new Image { ImageID = 1, ImagePath = "dgdfgdf", ProductID = 2}
                     },
                    CreatedDate=DateTime.Now,
                    Discount=0 ,
                     ProductDetails=new List<ProductDetail>()
                     {
                       new ProductDetail{ ProductDetailID=2, Size="S", Color=ProductDetail.ProductColor.Kırmızı, Stock=7 }
                     }
                },

                new Product
                {
                    ProductID=3,
                    BrandID=1,
                    CategoryID=1,
                    Description="Saten",
                    Gender="E",
                    Title="Saten Pantolon",
                    Price=60,
                    CreatedDate=DateTime.Now,
                    Discount=0,
                    Images = new List<Image>(){ new Image { ImageID = 5, ImagePath = "fwemfwmfw", ProductID = 3} },
                    ProductDetails=new List<ProductDetail>()
                    {
                       new ProductDetail{ ProductDetailID=3, Size="36", Color=ProductDetail.ProductColor.Siyah, Stock=3 }
                    }
                },

                new Product
                {
                    ProductID=4,
                    BrandID=2,
                    CategoryID=3,
                    Gender="E",
                    Description="İpek",
                    Title="İpek Gömlek",
                    Price=130,
                    CreatedDate=DateTime.Now,
                    Discount=0,
                      ProductDetails=new List<ProductDetail>()
                      {
                       new ProductDetail{ ProductDetailID=4, Size="L", Color=ProductDetail.ProductColor.Yeşil, Stock=7 }
                      }
                }

            };
            return View(products);
        }

    }
}