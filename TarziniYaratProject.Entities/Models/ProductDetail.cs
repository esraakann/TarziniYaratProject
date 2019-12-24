using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class ProductDetail : IEntity
    {
        public int ProductDetailID { get; set; }
        public string Size { get; set; }
        public ProductColor Color { get; set; }
        public int Stock { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }


        public enum ProductColor
        {
            Beyaz,
            Kırmızı,
            Siyah,
            Yeşil
        }
    }
}
