using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Key]
        [Required]
        public Guid Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        [Display(Name = "Название украшения")]
        public virtual string Name { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string ShortDesc { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string LongDesc { get; set; }

        [Display(Name = "Цена украшения")]
        public virtual ushort Price { get; set; }

        [Display(Name = "Любимое")]
        public virtual bool IsFavorite { get; set; }

        [Display(Name = "Наличие")]
        public virtual bool Avaliable { get; set; }

        [Display(Name = "Категория товара")]
        public virtual string Category { get; set; }

        [Display(Name = "Картинка")]
        public virtual string Image { get; set; }

        //[Display(Name = "Украшение")]
        //public virtual Jewelery Jewelery { get; set; }

        ////[Display(Name = "Список заказ")]
        ////public virtual List<ShopCartItem> ShopCartItems { get; set; }

        //[Display(Name = "ID корзины")]
        //public virtual Guid ShopCartID { get; set; }

    }
}
