using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarziniYaratProject.Core.Entity;

namespace TarziniYaratProject.Entities.Models
{
    public class Product:IEntity
    {
        public Product()
        {
            Images = new HashSet<Image>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            ProductDetails = new HashSet<ProductDetail>();
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
        }

        public int ProductID { get; set; }
        public int BrandID { get; set; }
        [Required(ErrorMessage ="Lütfen açıklamayı boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen başlığı boş geçmeyiniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen fiyatı boş geçmeyiniz")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal Price { get; set; }
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public int Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string Gender { get; set; }

        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }


    }
}
