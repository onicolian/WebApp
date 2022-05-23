using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class ShopCart : EntityBase
    {
        [Display(Name = "Список заказа")]
        public List<ShopCartItem> ShopCartItems { get; set; }

        private readonly AppDbContext context;

        public ShopCart(AppDbContext context)
        {
            this.context = context;
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context1 = services.GetService<AppDbContext>();
            string ID = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", ID);

            Guid shopCardID = Guid.Parse(ID);

            return new ShopCart(context1) { Id = shopCardID };
        }

        public void AddToCart(Jewelery jewelery)
        {
            this.context.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartID = Id,
                Jewelery = jewelery
            });

            context.SaveChanges();
        }

        public List<ShopCartItem> GetShopItem()
        {
            return context.ShopCartItem.Where(c => c.ShopCartID == Id).Include(s => s.Jewelery).ToList();
        }
    }
}
