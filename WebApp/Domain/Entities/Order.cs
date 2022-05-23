using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Order : EntityBase
    {
        [Required(ErrorMessage = "!!Введите ваше имя!!")]
        [Display(Name = "Имя")]
        public override string Name { get; set; }

        [Required(ErrorMessage = "!!Введите вашу фамилию!!")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "!!Введите ваш адрес!!")]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "!!Введите ваш номер телефона!!")]
        [Display(Name = "Номер телефоная")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "!!Введите вашу почту!!")]
        [Display(Name = "Почта")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Детали заказа")]
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
