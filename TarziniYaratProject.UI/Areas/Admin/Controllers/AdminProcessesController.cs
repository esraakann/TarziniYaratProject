﻿using System;
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

    }
}