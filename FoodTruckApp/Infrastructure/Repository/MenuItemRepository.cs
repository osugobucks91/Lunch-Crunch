using CoderCamps.Infrastructure.Repository;
using FoodTruckApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Infrastructure.Repository
{
    public class MenuItemRepository : GenericRepository<MenuItem>
    {
        public MenuItemRepository(ApplicationDbContext db) : base(db) { }

        protected override IQueryable<MenuItem> Include(IQueryable<MenuItem> query)
        {
            return query.Include(m => m.BusinessOwner)
                        .Include(m => m.FoodTruck);
        }

        public MenuItem FindById(int id, string username)
        {
            return (from m in Table
                    where m.Id == id && m.BusinessOwner.UserName == username
                    select m).FirstOrDefault();
        }

    }
}