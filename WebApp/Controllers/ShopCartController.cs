using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;
using WebApp.Domain.Repositories.EntityFramework;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IJeweleryRepository _jewRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IJeweleryRepository jewRep, ShopCart shopCart)
        {
            _jewRep = jewRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItem();
            _shopCart.ShopCartItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(Guid id)
        {
            var item = _jewRep.GetJewelery().FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }




       // private readonly DataManager dataManager;



       // public IActionResult Index(Guid id)
       // {
       //     if (id != default)
       //     {
       //         return View("Show", dataManager.ShopCart.GetShopCartById(id));
       //     }

       //     ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
       //     return View(dataManager.ShopCart.GetShopCart());
       // }

       ///* public RedirectToActionResult addToCart(int id)
       // {
       //     var item = dataManager.Jewelery.FirstOrDefault(x => x.Id == id);
       //     if(item != null)
       //     {
       //         dataManager.ShopCart.SaveShopCart(item);
       //     }
       //     return RedirectToAction("Index");
       // }*/

       // public IActionResult Edit(Guid id)
       // {
       //     var entity = id == default ? new ShopCart() : dataManager.ShopCart.GetShopCartById(id);
       //     return View(entity);
       // }
       // [HttpPost]
       // public IActionResult Edit(ShopCart model)
       // {
       //     if (ModelState.IsValid)
       //     {
       //         dataManager.ShopCart.SaveShopCart(model);
       //         return RedirectToAction("Index");
       //     }
       //     return View(model);
       // }
    }
}
