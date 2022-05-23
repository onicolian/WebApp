using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync(bool a)
        {
            if (a == true)
            {
                return Task.FromResult((IViewComponentResult)View("Catalog", dataManager.Jewelery.GetJewelery()));
            }
            else return Task.FromResult((IViewComponentResult)View("Default", dataManager.Jewelery.GetJewelery()));
        }
    }
}
