using CoderCamps.Infrastructure.Repository;
using FoodTruckApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Infrastructure.Repository
{
    public class FoodTruckRepository: GenericRepository<FoodTruck>
    {
        public FoodTruckRepository(DbContext db) : base(db) { }

        protected override IQueryable<FoodTruck> Include(IQueryable<FoodTruck> query)
        {
            return query.Include(f => f.MenuItems)
                    .Include(f => f.Reviews)
                    .Include(f => f.BusinessOwner);
        }

    }
}
