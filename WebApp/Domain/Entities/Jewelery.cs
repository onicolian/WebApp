using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Jewelery : EntityBase
    {
        [Required(ErrorMessage = "Заполните название украшения")]
        [Display(Name = "Название украшения")]
        public override string Name { get; set; }

        [Display(Name = "Краткое описание")]
        public override string ShortDesc { get; set; }

        [Display(Name = "Полное описание")]
        public override string LongDesc { get; set; }

        [Display(Name = "Цена украшения")]
        public override ushort Price { get; set; }

        [Display(Name = "Любимое")]
        public override bool IsFavorite { get; set; }

        [Display(Name = "Наличие")]
        public override bool Avaliable { get; set; }

        [Display(Name = "Категория товара")]
        public override string Category { get; set; }

        [Display(Name = "Картинка")]
        public override string Image { get; set; }

    }
}
