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
            ViewBag.Danger = null;
            if (Request.Cookies["login"] != null)
            {
                HttpCookie admin = Request.Cookies["login"];
                Person person = new Person();
                person.Username = admin["userName"];
               
                Session["Username"] = person.Username;
                return RedirectToAction("ProductList", "AdminProcesses");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(Person p, bool Remember=false)
        {

            Person login = _personService.AdminLogin(p);
            if (login != null)
            {
                if (Remember)
                {
                    HttpCookie cookie = new HttpCookie("login");
                    cookie.Values.Add("userName", p.Username);
                    cookie.Values.Add("password", p.Password);
                    cookie.Expires = DateTime.Now.AddDays(15);
                    Response.Cookies.Add(cookie);
                }
                Session["Username"] = login.Username;
                return RedirectToAction("ProductList", "AdminProcesses");
            }
            else
            {
                ViewBag.Danger = "Kullanıcı Adı veya Şifrenizi Kontrol Ediniz.";
                return View();
            }
        }

        public ActionResult LogOut()
        {
            ClearCookie();
            Session.Abandon();
            return RedirectToAction("Login");
        }


        public void ClearCookie()
        {
            if (Request.Cookies.AllKeys.Contains("login"))
            {
                HttpCookie cookie = Request.Cookies["login"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
        }

    }
}