using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Infrastructure.Repository
{
    public class ReviewRepository
    {
        public ReviewRepository(DbContext db) : base(db) { }

        protected override IQuarable<Review> Include(IQueryable<> )




    }
}