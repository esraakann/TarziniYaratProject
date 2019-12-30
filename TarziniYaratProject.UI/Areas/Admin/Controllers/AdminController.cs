using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;
using TarziniYaratProject.UI.Models;

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
            ViewBag.Danger = null;
            return View();
        }

        [HttpPost]
        public ActionResult Login(Person p)
        {

            Person login = _personService.AdminLogin(p);
            if (login != null)
            {
                Session["PersonID"] = login.PersonID;
                Session["Username"] = login.Username;
                Session["Password"] = login.Password;

                return RedirectToAction("ProductList", "AdminProcesses");

            }

            else
            {
                ViewBag.Danger = "Kullanıcı Adı veya Şifrenizi Kontrol Ediniz.";
                return View();
            }
        }

    }
}