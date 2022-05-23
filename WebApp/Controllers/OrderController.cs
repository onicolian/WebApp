using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository orders;
        private readonly ShopCart shopCart;

        public OrderController(IOrdersRepository orders, ShopCart shopCart)
        {
            this.orders = orders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.ShopCartItems = shopCart.GetShopItem();

            if(shopCart.ShopCartItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары в корзине!");
            }

            if (ModelState.IsValid)
            {
                orders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
