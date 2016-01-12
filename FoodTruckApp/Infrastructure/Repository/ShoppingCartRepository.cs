using CoderCamps.Infrastructure.Repository;
using FoodTruckApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Infrastructure.Repository {
    public class ShoppingCartRepository : GenericRepository<ShoppingCart> {

        public ShoppingCartRepository(DbContext db) : base(db) { }

        protected override IQueryable<ShoppingCart> Include(IQueryable<ShoppingCart> query) {
            return query.Include(s => s.Item).Include(t => t.Owner);
        }

        public IList<ShoppingCart> FindByOwner(string username) {
            return (from s in Table
                    where s.Owner.UserName == username
                    select s).ToList();
        }

        public ShoppingCart FindById(int id) {
            return (from s in Table
                    where s.Id == id
                    select s).FirstOrDefault();
        }

        public ShoppingCart FindByIdAndOwner(int id, string username) {
            return (from s in Table
                    where s.Id == id && s.Owner.UserName == username
                    select s).FirstOrDefault();
        }
    }
}