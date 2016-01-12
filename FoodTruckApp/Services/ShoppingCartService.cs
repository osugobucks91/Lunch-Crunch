using FoodTruckApp.Domain.Models;
using FoodTruckApp.Infrastructure.Repository;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FoodTruckApp.Services {
    public class ShoppingCartService {

        private ShoppingCartRepository _repo;

        private MenuItemRepository _menuRepo;

        private ApplicationUserManager _user;

        public ShoppingCartService(ShoppingCartRepository repo, MenuItemRepository menuRepo, ApplicationUserManager user) {
            _repo = repo;
            _menuRepo = menuRepo;
            _user = user;
        }

        private ShoppingCart Map(ShoppingCartDTO dtoCart) {
            return dtoCart != null ? new ShoppingCart() {
                Id = dtoCart.Id,
                Owner = _user.FindByName(dtoCart.Owner.UserName),
                Item = _menuRepo.FindById(dtoCart.Item.Id)
            } : null;
        }

        private ShoppingCartDTO Map(ShoppingCart dbCart) {
            return dbCart != null ? new ShoppingCartDTO() {
                Id = dbCart.Id,
                Owner = new ApplicationUserDTO() {
                    Id = dbCart.Owner.Id,
                    UserName = dbCart.Owner.UserName
                },
                Item = new MenuItemDTO() {
                    Id = dbCart.Item.Id,
                    Name = dbCart.Item.Name,
                    Price = dbCart.Item.Price,
                    Description = dbCart.Item.Description,
                    ImageUrl = dbCart.Item.ImageUrl
                }
            } : null;
        }

        [HttpPost]
        public void AddToCart(ShoppingCartDTO newCartItem) {
            _repo.Add(Map(newCartItem));
            _repo.SaveChanges();
        }

        public IList<ShoppingCartDTO> List(string username) {
            return _repo.FindByOwner(username).Select(s => Map(s)).ToList();
        }

        public void DeleteCartItem(int id, string username) {
            ShoppingCart s = _repo.FindByIdAndOwner(id, username);

            if (s != null) {
                _repo.Delete(id);
                _repo.SaveChanges();
            }
        }
    }
}