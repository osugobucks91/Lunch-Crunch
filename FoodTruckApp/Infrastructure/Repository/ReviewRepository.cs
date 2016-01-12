﻿using CoderCamps.Infrastructure.Repository;
using FoodTruckApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Infrastructure.Repository
{
    public class ReviewRepository: GenericRepository<Review>
    {
        public ReviewRepository(DbContext db) : base(db) { }

        protected override IQueryable<Review> Include(IQueryable<Review> query)
        {
            return query.Include(r => r.TruckId);
        }

        public Review FindById(int id)
        {
            return (from f in Table
                    where f.Id == id
                    select f).FirstOrDefault();
        }

    }
}