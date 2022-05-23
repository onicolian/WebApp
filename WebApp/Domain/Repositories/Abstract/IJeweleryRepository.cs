using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;

namespace WebApp.Domain.Repositories.Abstract
{
    public interface IJeweleryRepository
    {
        IQueryable<Jewelery> GetJewelery();
        Jewelery GetJeweleryById(Guid id);
        IQueryable<Jewelery> GetJeweleryByCategory(string category);
        void SaveJewelery(Jewelery entity);
        void DeleteJewelery(Guid id);
    }
}
