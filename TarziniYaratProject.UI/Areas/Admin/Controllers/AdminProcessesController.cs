using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarziniYaratProject.BLL.Abstract.EntityServices;
using TarziniYaratProject.Entities.Models;
using TarziniYaratProject.UI.Areas.Admin.Models;

namespace TarziniYaratProject.UI.Areas.Admin.Controllers
{
    public class AdminProcessesController : Controller
    {
        ISliderImageService _sliderImageService;

        IProductService _productService;
        ICategoryService _categoryService;
        IBrandService _brandService;
        IPersonService _personService;
        IProductDetailService _productDetailService;
        public AdminProcessesController(IProductService productService, ICategoryService categoryService, IBrandService brandService,IPersonService personService, IProductDetailService productDetailService, ISliderImageService sliderImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
            _personService = personService;
            _productDetailService = productDetailService;
            _sliderImageService = sliderImageService;
        }

        // GET: Admin/AdminProcesses
        public ActionResult ProductList(int catID = 0,int brandID=0)
        {
            if (catID!=0 && brandID==0)
            {
                return View(_productService.GetProductsByCatID(catID));
            }
            else if (catID == 0 && brandID != 0)
            {
                return View(_productService.GetProductsByBrandID(brandID));
            }
            return View(_productService.GetAll());
        }

        //while creating a new product,we need to add product's category which was created before.
        private void GetAllCategories()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            foreach (Category item in _categoryService.GetAll())
            {
                categories.Add(new SelectListItem { Text = item.Name, Value = item.CategoryID.ToString() });
            }
            ViewBag.Categories = categories;
        }

        //while creating a new product,we need to add product's brand which was created before.
        private void GetAllBrands()
        {
            List<SelectListItem> brands = new List<SelectListItem>();
            foreach (Brand item in _brandService.GetAll())
            {
                brands.Add(new SelectListItem { Text = item.Name, Value = item.BrandID.ToString() });
            }
            ViewBag.Brands = brands;
        }

        //MVC de kullanılabilecek diğer modeller Models klasörünün içinde olması doğru bir yönetim olacağını size attığım videoda adam diyordu.Genders enumını o yüzden oraya koydum.
        private void GetGendersFromEnum()
        {
            string[] genderEnums = Enum.GetNames(typeof(Genders));
            List<SelectListItem> genders = new List<SelectListItem>();
            foreach (string item in genderEnums)
            {
                genders.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.Genders = genders;
        }

        public ActionResult CreateProduct()
        {
            GetAllCategories();
            GetAllBrands();
            GetGendersFromEnum();
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            GetAllCategories();
            GetAllBrands();
            GetGendersFromEnum();
            //Todo :CreatedDate yanlış yönetildi.Bunu düzelt
            product.CreatedDate = DateTime.Now;
            //validationslar duruyor.
            if (product.Price != 0 || product.Title != string.Empty || product.Description != string.Empty || product.Discount != 0)
            {

                _productService.Insert(product);
            }

            return View();
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

        public JsonResult GetProductDetail(int id)
        {
            ProductDetail productDetail = _productDetailService.Get(id);
            var model = new
            {
                Id = productDetail.ProductID,
                Size = productDetail.Size,
                Color=productDetail.Color,
                Stock=productDetail.Stock
            };

            return productDetail != null ? Json(model, JsonRequestBehavior.AllowGet)
                : Json(new Exception("Ürün Detayı Bulunamadı").Message, JsonRequestBehavior.AllowGet);
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

        public ActionResult CategoryList()
        {
            return View(_categoryService.GetAll().ToList());
        }

        [HttpPost]
        public JsonResult CategoryDelete(int id)
        {
            try
            {
                Category category = _categoryService.Get(id);
                _categoryService.Delete(category);
            }
            catch (Exception ex)
            {
                return Json(ex.InnerException.Message, JsonRequestBehavior.AllowGet);
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {

            _categoryService.Insert(category);
            return RedirectToAction("CategoryList");
        }

        public ActionResult UpdateCategory(int catID)
        {
            Category category = _categoryService.Get(catID);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category _category)
        {
            Category category = _categoryService.Get(_category.CategoryID);
            category.Decription = _category.Decription;
            category.Name = _category.Name;
            _categoryService.Update(category);
            return RedirectToAction("CategoryList");
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


        public ActionResult BrandList()
        {
            return View(_brandService.GetAll());
        }
        public ActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBrand(Brand brand)
        {
            _brandService.Insert(brand);
            return RedirectToAction("BrandList");
        }

        public JsonResult UpdateBrand(Brand brd)
        {
            try
            {
                Brand brand = _brandService.Get(brd.BrandID);
                brand.Name = brd.Name;
                _brandService.Update(brand);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult GetBrand(int id)
        {
            Brand brand = _brandService.Get(id);
            //model viewmodel olarak eklenirse çok güzel olur.
            var model = new
            {
                Id = brand.BrandID,
                Name = brand.Name
            };

            return brand != null ? Json(model, JsonRequestBehavior.AllowGet)
                : Json(new Exception("Marka Bulunamadı").Message, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteBrand(int id)
        {
            try
            {
                _brandService.DeleteById(id);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

      
    }
}