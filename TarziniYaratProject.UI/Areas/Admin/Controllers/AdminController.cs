using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Login()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult Login(Person p)
        {
            return View(p);
        }

        public ActionResult Login2()
        {
            return View(new Person());
        }
    }
}