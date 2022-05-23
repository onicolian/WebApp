using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class ShopCartItem : EntityBase
    {
        [Display(Name = "Украшение")]
        public Jewelery Jewelery { get; set; }

        [Display(Name = "ID корзины")]
        public Guid ShopCartID { get; set; }
    }
}
