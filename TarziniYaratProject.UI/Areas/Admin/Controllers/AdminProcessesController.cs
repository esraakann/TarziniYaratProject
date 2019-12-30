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
        IPersonService _personService;
        public AdminProcessesController(IProductService productService,IPersonService personService)
        {
            _productService = productService;
            _personService = personService;
        }
        // GET: Admin/AdminProcesses
        public ActionResult ProductList()
        {
            return View(_productService.GetAll());
        }
        public JsonResult DeleteProduct(int id)
        {
            Product cat = _productService.Get(id);
            _productService.Delete(cat);
            //_context.SaveChanges();
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
        public ActionResult UserList()
        {
            return View(_personService.GetAll());
        }
        public JsonResult UpdatePerson(int id)
        {
            Person person = _personService.Get(id);
            if (person.IsActive == true)
            {
                person.IsActive = false;
            }
            else
            {
                person.IsActive = true;
            }
            _personService.Update(person);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

    }
}