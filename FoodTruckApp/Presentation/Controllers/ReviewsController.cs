using FoodTruckApp.Presentation.Models;
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
    [RoutePrefix("api/reviews")]
    public class ReviewsController : ApiController
    {
        private ReviewService _reviewsService;

        public ReviewsController(ReviewService reviewsService)
        {
            _reviewsService = reviewsService;

        }

        [HttpPost]
        public IHttpActionResult Post(ReviewDTO newReview) {
            if (ModelState.IsValid) {
                newReview.TruckId = new FoodTruckDTO() {
                    Id = newReview.TruckId.Id
                };
                _reviewsService.AddReview(newReview);
                return Ok();
            }
            else {
                return BadRequest(ModelState);
            }
        }
    }
}
