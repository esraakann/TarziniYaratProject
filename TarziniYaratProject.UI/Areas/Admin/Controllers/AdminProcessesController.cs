using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{
    public class AdminProcessesController : Controller
    {
        IProductService _productService;
        public AdminProcessesController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Admin/AdminProcesses
        public ActionResult ProductList()
        {
            return View(_productService.GetAll());
        }
        public JsonResult DeleteProduct(int id)
        {
            Product prod = _productService.Get(id);
            try
            {
                _productService.Delete(prod);
            }
            catch (Exception ex)
            {

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
                throw;
            }
            //_context.SaveChanges();
            return Json("ok", JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetProduct(int id)
        {
            Product product = _productService.Get(id);
            //model viewmodel olarak eklenirse çok güzel olur.
            var model = new
            {
                Id = product.ProductID,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price
            };

            return product != null ? Json(model, JsonRequestBehavior.AllowGet)
                : Json(new Exception("Ürün Bulunamadı").Message, JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateProduct(Product prod)
        {
            try
            {
                Product product = _productService.Get(prod.ProductID);
                product.Title = prod.Title;
                product.Price = prod.Price;
                product.Description = prod.Description;
                _productService.Update(product);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }

            return Json("ok", JsonRequestBehavior.AllowGet);
        }

    }
}