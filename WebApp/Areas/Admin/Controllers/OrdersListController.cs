using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp.Service;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersListController : Controller
    {
        private readonly DataManager dataManager;

        public OrdersListController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.Orders.GetOrders());
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Orders.DeleteOrder(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
