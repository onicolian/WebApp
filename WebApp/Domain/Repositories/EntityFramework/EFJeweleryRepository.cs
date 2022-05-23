using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain.Entities;
using WebApp.Domain.Repositories.Abstract;

namespace WebApp.Domain.Repositories.EntityFramework
{
    public class EFJeweleryRepository : IJeweleryRepository
    {
        private readonly AppDbContext context;

        public EFJeweleryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Jewelery> GetJewelery()
        {
            return context.Jewelery;
        }

        public Jewelery GetJeweleryById(Guid id)
        {
            return context.Jewelery.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Jewelery> GetJeweleryByCategory(string category)
        {
            IQueryable<Jewelery> list = context.Jewelery.Where(itm => itm.Category == category);
            return list;
        }

        public void SaveJewelery(Jewelery entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteJewelery(Guid id)
        {
            context.Jewelery.Remove(new Jewelery() { Id = id });
            context.SaveChanges();
        }

    }
}
