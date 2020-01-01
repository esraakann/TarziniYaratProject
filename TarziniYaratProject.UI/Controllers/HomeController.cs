using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;

namespace TarziniYaratProject.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IProductService _productService;
        ICategoryService _categoryService;
        public HomeController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Products(int catID= 0)
        {
            ViewBag.Categories = _categoryService.GetAll().ToList();
            return View(_productService.GetProductsByCatID(catID));
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}