using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class JeweleryController : Controller
    {
        private readonly DataManager dataManager;

        public JeweleryController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Jewelery.GetJeweleryById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.Jewelery.GetJewelery());
        }

        public IActionResult Category(String category)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.Jewelery.GetJeweleryByCategory(category));
        }
    }
}
