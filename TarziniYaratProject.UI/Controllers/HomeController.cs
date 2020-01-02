using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.DAL.Concrete.EntityFramework;
using TarziniYaratProject.UI.Models;

namespace TarziniYaratProject.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IProductService _productService;
        ICategoryService _categoryService;
        IImageService _imageService;
        ISliderImageService _sliderImageService;
        public HomeController(IProductService productService, ICategoryService categoryService,IImageService imageService,ISliderImageService sliderImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _imageService = imageService;
            _sliderImageService = sliderImageService;
        }

        public ActionResult Index()
        {

            //HomeVM homeVM = new HomeVM();
            //homeVM.Images = _imageService.GetAll().ToList();
            //homeVM.Products = _productService.GetAll().ToList();
            ViewBag.SliderImages = _sliderImageService.GetAll();
            return View(_productService.GetAll().ToList());
            
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Products(int catID = 0, string catName = null)
        {
        
            if (catName == null)
            {
                ViewBag.Categories = _categoryService.GetAll().ToList();
                return View(_productService.GetProductsByCatID(catID));

            }
            else
            {
                //ViewBag.Images = _imageService.GetAll().ToList();
                ViewBag.Categories = _categoryService.GetAll().ToList();
                return View(_productService.GetProductsByCatName(catName));
            }
        }
        //public ActionResult GetByCategoryName(string catName)
        //{
        //    return View();
        //}
        public ActionResult Contact()
        {
            return View();
        }
    }
}