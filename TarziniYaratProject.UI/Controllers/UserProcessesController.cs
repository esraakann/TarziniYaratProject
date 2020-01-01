using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Controllers
{
    public class UserProcessesController : Controller
    {
        IPersonService _personService;
        public UserProcessesController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult ChooseProcess()
        {
            return View();
        }

        public ActionResult Register()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Register(Person person)
        {
            _personService.Insert(person);
            return RedirectToAction("Login"); 
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Person p)
        {
            return View();
        }
    }
}