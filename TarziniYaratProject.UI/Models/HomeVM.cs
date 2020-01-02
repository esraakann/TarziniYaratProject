using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TarziniYaratProject.Entities.Models;

namespace TarziniYaratProject.UI.Models
{
    public class HomeVM
    {
        public HomeVM()
        {
            Products = new List<Product>();
            Images = new List<Image>();

        }
        public ICollection<Product> Products { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}