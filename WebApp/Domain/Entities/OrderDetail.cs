using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Номер заказа")]
        public Guid OrderID { get; set; }

        [Display(Name = "ID украшения")]
        public Guid JeweleryID  { get; set; }

        [Display(Name = "Цена")]
        public ushort Price { get; set; }

        [Display(Name = "Украшение")]
        public virtual Jewelery Jewelery { get; set; }

        [Display(Name = "Заказ")]
        public virtual Order Order { get; set; }

    }
}
