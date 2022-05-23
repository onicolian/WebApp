using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFOrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext context;
        private readonly ShopCart shopCart;

        public EFOrdersRepository(AppDbContext context, ShopCart shopCart)
        {
            this.context = context;
            this.shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            context.Order.Add(order);
            var items = shopCart.ShopCartItems;
            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    JeweleryID = el.Jewelery.Id,
                    OrderID = order.Id,
                    Price = el.Jewelery.Price
                };
                context.OrderDetail.Add(orderDetail);
            }
            context.SaveChanges();
        }

        public IQueryable<Order> GetOrders()
        {
            return context.Order;
        }

        public void DeleteOrder(Guid id)
        {
            context.Order.Remove(new Order() { Id = id });
            context.SaveChanges();
        }

        public Order GetOrderById(Guid id)
        {
            return context.Order.FirstOrDefault(x => x.Id == id);
        }
    }
}
