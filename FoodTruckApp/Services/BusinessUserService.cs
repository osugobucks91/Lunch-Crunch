using FoodTruckApp.Domain.Models;
using FoodTruckApp.Infrastructure.Repository;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTruckApp.Services
{
    public class BusinessUserService
    {

        private FoodTruckRepository _foodTruckRepo;

        private ApplicationUserManager _userManager;

        public BusinessUserService(FoodTruckRepository foodTruckRepo, DbContext context)
        {

            _foodTruckRepo = foodTruckRepo;

            _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

        }

    }
}
