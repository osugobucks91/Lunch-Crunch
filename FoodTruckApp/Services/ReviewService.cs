using FoodTruckApp.Domain.Models;
using FoodTruckApp.Infrastructure.Repository;
using FoodTruckApp.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckApp.Services
{
    public class ReviewService
    {
        private ReviewRepository _reviewRepo;
        private FoodTruckRepository _foodTruckRepo;

        public ReviewService(ReviewRepository reviewRepo, FoodTruckRepository foodTruckRepo)
        {
            _reviewRepo = reviewRepo;
            _foodTruckRepo = foodTruckRepo;
        }

        private Review Map(ReviewDTO dtoReview) {
            return dtoReview != null ? new Review() {
                Id = dtoReview.Id,
                StarRating = dtoReview.StarRating,
                Message = dtoReview.Message,
                TruckId = _foodTruckRepo.FindById(dtoReview.TruckId.Id)
            } : null;
        }

        public void AddReview(ReviewDTO newReview)
        {
            _reviewRepo.Add(Map(newReview));
            _reviewRepo.SaveChanges();
        }


    }
}