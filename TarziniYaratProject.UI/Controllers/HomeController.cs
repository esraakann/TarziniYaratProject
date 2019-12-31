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
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View(_productService.GetAll().ToList());
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}