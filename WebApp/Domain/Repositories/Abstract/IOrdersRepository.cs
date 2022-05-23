using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IOrdersRepository
    {
        IQueryable<Order> GetOrders();
        void CreateOrder(Order order);
        Order GetOrderById(Guid id);
        void DeleteOrder(Guid id);
    }
}