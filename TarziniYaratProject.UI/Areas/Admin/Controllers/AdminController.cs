using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{

    public class AdminController : Controller
    {
        IPersonService _personService;
        public AdminController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Login()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult Login(Person p)
        {
            bool login = _personService.AdminLogin(p);
            if (login)
            {
                if (p.Password.Length>=6 && p.Password.Length<=16)
                {
                    return RedirectToAction("ProductList", "AdminProcesses");
                }
                else
                {
                    TempData["passwordErrorMessage"] = "Şifreniz 6-16 karakter uzunluğunda olmalıdır.";
                    return View();
                }
               
            }

            else
            {
                TempData["errorMessage"] = "Kullanıcı Adı veya Şifrenizi Kontrol Ediniz.";
                return View();
            }
        }
        public ActionResult example()
        {
            return View();
        }
    }
}