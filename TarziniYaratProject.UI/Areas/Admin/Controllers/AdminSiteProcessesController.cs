using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;
using TarziniYaratProject.UI.AppClasses;
using Image = System.Drawing.Image;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{
    public class AdminSiteProcessesController : Controller
    {
        ISliderImageService _sliderImageService;
        public AdminSiteProcessesController(ISliderImageService sliderImageService)
        {
            _sliderImageService = sliderImageService;
        }

        public ActionResult SliderList()
        {
            List<SliderImage> sliders = _sliderImageService.GetAll() as List<SliderImage>;
            return View(sliders);
        }

        public ActionResult CreateSliderImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSliderImage(HttpPostedFileBase fileUpload)
        {
            if (fileUpload!=null)
            {
                Image image = Image.FromStream(fileUpload.InputStream);
                Bitmap bitmap = new Bitmap(image, Settings.SliderImageSize);
                string extension = "/Images/Sliders/" + Guid.NewGuid() + Path.GetExtension(fileUpload.FileName);
                bitmap.Save(Server.MapPath(extension));

                SliderImage slider = new SliderImage();
                slider.ImagePath = extension;
                slider.IsActive = true;
                _sliderImageService.Insert(slider);
            }
            return RedirectToAction("SliderList","Admin/AdminSiteProcesses"); 
        }

        public JsonResult UpdateActive(int id)
        {
            try
            {
                _sliderImageService.UpdateActive(id);
            }
            catch (Exception)
            {
                ViewData["ErrorActive"] = "Hata";
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

    }
}