using FoodTruckApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodTruckApp.Presentation.Controllers
{
    [Authorize]
    public class ShoppingCartController : ApiController
    {

        private ShoppingCartService _shoppingCartService;

        public ShoppingCartController(ShoppingCartService shoppingCartService) {
            _shoppingCartService = shoppingCartService;
        }

        public IList<ShoppingCartDTO> Get() {
            return _shoppingCartService.List(User.Identity.Name);
        }

        public IHttpActionResult Post(ShoppingCartDTO newItem) {
            if (ModelState.IsValid) {
                newItem.Owner = new ApplicationUserDTO() {
                    UserName = User.Identity.Name
                };
                newItem.Item = new MenuItemDTO() {
                    Id = newItem.Item.Id
                };
                _shoppingCartService.AddToCart(newItem);
                return Ok();
            }
            else {
                return BadRequest(ModelState);
            }
        }

        public void Delete(int id) {
            _shoppingCartService.DeleteCartItem(id, User.Identity.Name);
        }
    }
}
