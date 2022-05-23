using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly DataManager dataManager;

        public OrderController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        //public IActionResult Index(Guid id)
        //{
        //    return View(dataManager..GetOrderById(id));
        //}
    }
}
