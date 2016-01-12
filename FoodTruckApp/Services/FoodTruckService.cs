using FoodTruckApp.Domain.Models;
using FoodTruckApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FoodTruckApp.Services {
    public class FoodTruckService {

        private FoodTruckRepository _repo;

        public FoodTruckService(FoodTruckRepository repo) {
            _repo = repo;
        }

        private FoodTruckDTO Map(FoodTruck dbFoodTruck) {
            return dbFoodTruck != null ? new FoodTruckDTO() {
                Id = dbFoodTruck.Id,
                Name = dbFoodTruck.Name,
                Image = dbFoodTruck.Image,
                Description = dbFoodTruck.Description,
                Location = dbFoodTruck.Location,               
                MenuItems = (from m in dbFoodTruck.MenuItems
                             select new MenuItemDTO() {
                                 Id = m.Id,
                                 Name = m.Name,
                                 Price = m.Price,
                                 Description = m.Description,
                                 ImageUrl = m.ImageUrl
                             }).ToList(),
                Reviews = (from r in dbFoodTruck.Reviews
                           select new ReviewDTO() {
                               Id = r.Id,
                               StarRating = r.StarRating,
                               Message = r.Message
                           }).ToList()
            } : null;
        }

        //Get a list of food trucks for list view
        public IList<FoodTruckDTO> List() {
            return (from a in _repo.List()
                    select Map(a)).ToList();
        }

        public FoodTruckDTO FindById(int id)
        {
            return Map(_repo.FindById(id));
        }
    }
}
