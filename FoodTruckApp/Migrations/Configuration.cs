namespace FoodTruckApp.Migrations
{
    using Domain.Models;
    using Infrastructure;
    using Infrastructure.Repository;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var reviews = new Review[]
            //belly up food truck
            {
                new Review
                {
                    Id=1,
                    StarRating=4,
                    Message="I ordered the monte Cristo egg rolls and a boudain ball just to try. I am kicking myself I didn't get a full order. A little spicy but I am a wimp and still really enjoyed it."
                },
                new Review
                {
                    Id=2,
                    StarRating=5,
                    Message="Only thing we got were Boudain balls.The guy was basically closing up but made them for us anyways and gave an extra one."
                },
                new Review
                {
                    Id=3,
                    StarRating=4,
                    Message="I got their boudain balls by accident and I have to say I was glad for the mix up. Some of the better boudain balls I've had. Additionally got their fries, and those were flavorful as well."
                },
            // dasmanReviews = new Review[]
                new Review
                {
                    Id=4,
                    StarRating=5,
                    Message="Been to all four corners of the states and by far the best most genuine authentic food is being served at dasman food truck, I can say that I  have finally found the home away from home reminds me of the shawerma in Damascus syria"
                },
                new Review
                {
                    Id=5,
                    StarRating=5,
                    Message="Best shawarma I ever had in two years, I wish the had a place I can take my family to"
                },
                new Review
                {
                    Id=6,
                    StarRating=3,
                    Message="Very slow in fulfilling orders and not very organized. Suggest some process to figure out the order in which people placed their orders and more efficiency in the kitchen. Shawerma wasn't that good."
                },
            // stjohnReviews = new Review[]
                new Review
                {
                    Id=7,
                    StarRating=5,
                    Message="I thought I had written a review for this truck, but it's not there anymore on yelp.  I've tried several of his dishes on multiple visits, and they're all really great.  Obviously the egg rolls are a must."
                },
                new Review
                {
                    Id=8,
                    StarRating=3,
                    Message="Skewered meats aren't exactly the type of food that you would expect to find off of a food truck, but that's exactly what St. John's Fire specializes in. I suppose that it makes sense that they could cook up these little meat popsicles since there a lot of BBQ places smoke their meats on pits attached to their food trucks. "
                },
                new Review
                {
                    Id=9,
                    StarRating=5,
                    Message="I have tremendous love for everything fried and battered that come out of this truck. They know how to do greasy food right."
                },
            // berniesReviews = new Review[]
                new Review
                {
                    Id=10,
                    StarRating=5,
                    Message="If you're a burger and fries person, you have got to try Bernie's Burger Bus!!  Their burgers are absolutely delicious and worth every single bite!! Oh and don't worry if you aren't a burger person, I peaked at the salad section on the menu and they sound really amazing too"
                },
                new Review
                {
                    Id=11,
                    StarRating=5,
                    Message="These are some of the most well made burgers I've had. The menu is based on school, and you sit at desks. The kitchen is a big yellow school bus, and the best part is, they have local Texas beer."
                },
                new Review
                {
                    Id=12,
                    StarRating=5,
                    Message="Wow is all I can say about this place. I read the reviews.  I did my research.  I knew it would be good.  I was still really impressed on how good it really was. "
                },
            // skratchReviews = new Review[]
                new Review
                {
                    Id=13,
                    StarRating=4,
                    Message="Omg I stumbled on this place at HEB Friday night and had their mushroom burger. I asked to add bacon and I think it seriously was the best burger I've had in ages."
                },
                new Review
                {
                    Id=14,
                    StarRating=5,
                    Message="Everything was absolutely delicious and it was all exceptionally reasonably priced! I could have bathed in the fries!"
                },
                new Review
                {
                    Id=15,
                    StarRating=4,
                    Message="This truck has it all.  Exceptional food, fast and friendly service, variety and big smiles!  They are an inspiration to other food trucks!"
                },
                new Review
                {
                    Id=16,
                    StarRating=5,
                    Message="This is the best food truck I've found in Houston. Though their food is heavy, it is always delicious.  I personally love the Lobster Roll. Think about it, who in the world would ever pay $15 for a sandwich off a truck? THIS GUY!!"
                },
                new Review
                {
                    Id=17,
                    StarRating=4,
                    Message="Just order the lobster roll. The bread is thick and buttered (like thick Texas toast), and the roll itself is filled with huge, tender pieces of fresh lobster."
                },
            // wafflebusReviews = new Review[]
                new Review
                {
                    Id=18,
                    StarRating=4,
                    Message="Delicious!  I had the fried chicken and waffle with a mix of spicy mayo and ancho chile honey and the flavor combination was awesome! "
                },
                new Review
                {
                    Id=19,
                    StarRating=3,
                    Message="I'll give it 3 stars cause I never wrote a review when it first started but when I first had it in 2013 it was amazing! "
                },
                new Review
                {
                    Id=20,
                    StarRating=4,
                    Message="It was my first time trying chicken and waffles. My boyfriend has raved about them for a while now. I was pretty anti-chicken and waffles but after a few drinks I figured I'd be a little adventurous and give them a try. "
                }
            };

            //***************************************

            var menuItems = new MenuItem[]
            {

            //bellyUp
                new MenuItem
                {
                    Id=1,
                    Name="Potato Taco",
                    Price = 4.0m,
                    Description="Tater tots, portabella-black bean salsa, piquillo peppers, salsa verde, feta, preserved lemon crema",
                    ImageUrl="http://www.recipe.com/images/taco-potato-skins-R100279-ss.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="Chicken and Waffle Taco",
                    Price=5.0m,
                    Description="Springer Mtn Farms chicken, avocado ranch, pickled slaw, cotija, waffle shell",
                    ImageUrl="http://cdn.recipes100.com/v/5eeb5333b3d350a3b890329391730e16.jpg"
                },
                new MenuItem
                {
                    Id=3,
                    Name="Steak Taco",
                    Price=4.0m,
                    Description="Hickory Nut Gap skirt steak, charred kale, picked radish, fried onions, kimchi ranch, feta",
                    ImageUrl="http://www.recipe.com/images/cowboy-steak-tacos-R143032-ss.jpg"
                },
                new MenuItem
                {
                    Id=4,
                    Name="Chicken Confit Burrito",
                    Price=8.0m,
                    Description="Springer Mtn farms chicken, tater tots, piquillo peppers, cheddar, arugula, salsa verde, preserved lemon crema",
                    ImageUrl="http://cdn-image.myrecipes.com/sites/default/files/styles/300x300/public/image/recipes/oh/gbp/chicken-burritos-gb-x.jpg?itok=05Kfn-K4"
                },
            //dasman
                new MenuItem
                {
                    Id=5,
                    Name="Chicken over rice",
                    Price = 10m,
                    Description="Chicken over rice",
                    ImageUrl="http://hostedmedia.reimanpub.com/TOH/Images/Photos/37/300x300/exps819_FFR1450842D18.jpg"
                },
                new MenuItem
                {
                    Id=6,
                    Name="Chicken shaurma",
                    Price=8m,
                    Description="Chicken shaurma",
                    ImageUrl="http://allthecooking.com/wp-content/uploads/2015/11/Chicken-Shawarma.jpg"
                },
            // stjohns
                new MenuItem
                {
                    Id=7,
                    Name="Cajun Egg roll",
                    Price = 5m,
                    Description="shrimp, crawfish, tasso ham and guava mustard",
                    ImageUrl="http://cdn.recipes100.com/v/3956de0cf5e69a0dde9bb68fcddec86e.jpg"
                },
                new MenuItem
                {
                    Id=8,
                    Name="Hot and Crunchy Chicken Sandwich",
                    Price=8m,
                    Description="with fig preserves, applewood-smoked bacon and torched brie on chabatta bread",
                    ImageUrl="http://www.recipe.com/images/hot-and-crunchy-chicken-cones-1360-ss.jpg"
                },
                new MenuItem
                {
                    Id=9,
                    Name="Slow Roasted Pulled Pork Sandwich",
                    Price = 8m,
                    Description="lightly smoked pork with marinated slaw and Creole mustard on ciabatta bread",
                    ImageUrl="http://www.recipe.com/images/slow-cooked-pulled-pork-sandwiches-26160-ss.jpg"
                },
                new MenuItem
                {
                    Id=10,
                    Name="Tortilla Crusted Fish Tacos",
                    Price=8m,
                    Description="with marinated cabbage, pico de gallo and lime-cilantro rice",
                    ImageUrl="https://s-media-cache-ak0.pinimg.com/736x/29/e5/07/29e507aa543233426fac2a20de33ce2a.jpg"
                },
            //bernies
                new MenuItem
                {
                    Id=11,
                    Name="The principal",
                    Price = 9m,
                    Description="Classic burger with a choice of cheese, all homemade mayonnaise, mustard, ketchup, thin sliced onions, pickles, shredded lettuce, and slow roasted garlic tomatoes",
                    ImageUrl="http://www.nancyskitchen.com/frenchs-mustard-recipes/Frenchs_Classic_Burgers.jpg"
                },
                new MenuItem
                {
                    Id=12,
                    Name="The cheerleader",
                    Price=10.25m,
                    Description="Pepper jack cheeseburger, crisp y jalapenos, slow roasted garlic tomatoes, shredded lettuce, and jalapeno ranch",
                    ImageUrl="http://www.burgerweekly.com/wp-content/uploads/2014/01/IMG_0776-300x300.jpg"
                },
            //skratch
                new MenuItem
                {
                    Id=13,
                    Name="Lobster Roll",
                    Price = 15m,
                    Description="Live Maine Lobster Meat, Chives, Dill, Celery and Mayo",
                    ImageUrl="https://www.theinfatuation.com/wp-content/uploads/2015/08/Ruschmeyers-Montauk-Lobster-Roll-Photo-Credit-Ashley-Sears-300x300.jpg"
                },
                new MenuItem
                {
                    Id=14,
                    Name="Brazilian Steak Sandwich",
                    Price=10m,
                    Description="Shaved Rib Eye, Homemade Chimichuri, Shaved Red Onions on Hoggie Roll",
                    ImageUrl="http://www.recipe.com/images/cajun-steak-sandwich-with-sweet-potato-fries-R145148-ss.jpg"
                },
            //wafflebus
                new MenuItem
                {
                    Id=15,
                    Name="Waffle Burger",
                    Price = 8m,
                    Description="Quarter pound beef patty with American cheese, crisp romain lettuce",
                    ImageUrl="http://www.lamag.com/wp-content/uploads/sites/9/2015/10/WaffleSando-300x300.jpg"
                },
                new MenuItem
                {
                    Id=16,
                    Name="Smoked Salmon Waffle",
                    Price=8m,
                    Description="With lemon, organic baby spinach, sliced tomatos",
                    ImageUrl="http://secretlifeoffatbacks.com/wp-content/uploads/2015/03/IMG_5760-300x300.jpg"
                }
            };

            //------food trucks------------

            var foodTrucks = new FoodTruck[]
            {
                new FoodTruck
                {
                    Id=1,
                    Name = "Belly Up",
                    Image = "https://www.foodtrucksin.com/sites/default/files/styles/truck_food_gallery/public/20150429_110901.jpg?itok=ur2nK19w",
                    Description = "Belly Up is proud to serve American cuisine with ethnic twists",
                    Location = "11308 W Broadway St, Pearland, TX 77584"
                },
                new FoodTruck
                {
                    Id=2,
                    Name = "Dasman",
                    Image = "https://pbs.twimg.com/media/CTLgksaUYAAKdNT.jpg",
                    Description = "A Taste of the Mediterranean. Bringing you Authentic Mediterranean Shawarma wraps",
                    Location = "2220 Brazos St, Houston, TX 77002"
                },
                new FoodTruck
                {
                    Id=3,
                    Name = "St.Johns Fire",
                    Image = "https://pbs.twimg.com/media/CRsABfQVAAA-FFE.jpg",
                    Description = "Seafood, Cajun/Creole, Mac 'n Cheese",
                    Location = "1500 Hermann Dr, Houston, TX 77004"
                },
                new FoodTruck
                {
                    Id=4,
                    Name = "Bernie's Bus",
                    Image = "https://pbs.twimg.com/media/CLU2nOJUAAAq8mT.jpg",
                    Description = "Serving homemade tasty burgers, hand cut fries, as well as all homemade condiments",
                    Location = "6355 Clara Rd, Houston, TX 77041"
                },
                new FoodTruck
                {
                    Id=5,
                    Name = "Skratch Food Truck",
                    Image = "https://scontent-dfw1-1.xx.fbcdn.net/hphotos-xfp1/v/t1.0-9/12347858_1045443922188255_7182050856081769376_n.jpg?oh=20b3ba58eca6688bad04055b1e608ee2&oe=5714BAAD",
                    Description = "Eclectic food on the go with some Texas flair and locally grown ingredients",
                    Location = "1 Reliant Pkwy Houston, TX 77054"
                },
                new FoodTruck
                {
                    Id=6,
                    Name = "The Waffle Bus",
                    Image = "http://houstonstop100foodtrucks.com/wp-content/gallery/houstons-top-100-food-trucks/dscn2140.jpg",
                    Description = "Waffles, Wings, Sandwiches",
                    Location = "1953 Montrose, TX 77019 "
                }
            };

            context.Reviews.AddOrUpdate(r => r.Id, reviews);

            context.MenuItems.AddOrUpdate(m => m.Id, menuItems);

            context.FoodTrucks.AddOrUpdate(f => f.Id, foodTrucks);

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            //-----customers---------

            var test = userManager.FindByName("test");
            if (test == null)
            {
                test = new ApplicationUser()
                {
                    UserName = "test",
                    Email = "test@test.com"
                };
                userManager.Create(test, "Password!1");
            }

            var daniel = userManager.FindByName("test");
            if (daniel == null)
            {
                daniel = new ApplicationUser()
                {
                    UserName = "daniel.roberts@gmail.com",
                    Email = "daniel.roberts@gmail.com"
                };
                userManager.Create(daniel, "Password!1");
            }

            var kara = userManager.FindByName("kara.johnson@gmail.com");
            if (kara == null)
            {
                kara = new ApplicationUser()
                {
                    UserName = "kara.johnson@gmail.com",
                    Email = "kara.johnson@gmail.com"
                };
                userManager.Create(kara, "Password!1");
            }

            var emma = userManager.FindByName("emma.perfect@gmail.com");
            if (emma == null)
            {
                emma = new ApplicationUser()
                {
                    UserName = "emma.perfect@gmail.com",
                    Email = "emma.perfect@gmail.com"
                };
                userManager.Create(emma, "Password!1");
            }

            var patrick = userManager.FindByName("patrick.mccomb@gmail.com");
            if (patrick == null)
            {
                patrick = new ApplicationUser()
                {
                    UserName = "patrick.mccomb@gmail.com",
                    Email = "patrick.mccomb@gmail.com"
                };
                userManager.Create(patrick, "Password!1");
            }

            ReviewRepository reviewRepo = new ReviewRepository(context);

            var review1 = reviewRepo.FindById(1);
            var review2 = reviewRepo.FindById(2);
            var review3 = reviewRepo.FindById(3);
            var review4 = reviewRepo.FindById(4);
            var review5 = reviewRepo.FindById(5);
            var review6 = reviewRepo.FindById(6);
            var review7 = reviewRepo.FindById(7);
            var review8 = reviewRepo.FindById(8);
            var review9 = reviewRepo.FindById(9);
            var review10 = reviewRepo.FindById(10);
            var review11 = reviewRepo.FindById(11);
            var review12 = reviewRepo.FindById(12);
            var review13 = reviewRepo.FindById(13);
            var review14 = reviewRepo.FindById(14);
            var review15 = reviewRepo.FindById(15);
            var review16 = reviewRepo.FindById(16);
            var review17 = reviewRepo.FindById(17);
            var review18 = reviewRepo.FindById(18);
            var review19 = reviewRepo.FindById(19);
            var review20 = reviewRepo.FindById(20);

            MenuItemRepository menuItemRepo = new MenuItemRepository(context);

            var menuItem1 = menuItemRepo.FindById(1);
            var menuItem2 = menuItemRepo.FindById(2);
            var menuItem3 = menuItemRepo.FindById(3);
            var menuItem4 = menuItemRepo.FindById(4);
            var menuItem5 = menuItemRepo.FindById(5);
            var menuItem6 = menuItemRepo.FindById(6);
            var menuItem7 = menuItemRepo.FindById(7);
            var menuItem8 = menuItemRepo.FindById(8);
            var menuItem9 = menuItemRepo.FindById(9);
            var menuItem10 = menuItemRepo.FindById(10);
            var menuItem11 = menuItemRepo.FindById(11);
            var menuItem12 = menuItemRepo.FindById(12);
            var menuItem13 = menuItemRepo.FindById(13);
            var menuItem14 = menuItemRepo.FindById(14);
            var menuItem15 = menuItemRepo.FindById(15);
            var menuItem16 = menuItemRepo.FindById(16);

            FoodTruckRepository foodTruckRepo = new FoodTruckRepository(context);

            var foodTruck1 = foodTruckRepo.FindById(1);
            var foodTruck2 = foodTruckRepo.FindById(2);
            var foodTruck3 = foodTruckRepo.FindById(3);
            var foodTruck4 = foodTruckRepo.FindById(4);
            var foodTruck5 = foodTruckRepo.FindById(5);
            var foodTruck6 = foodTruckRepo.FindById(6);

            review1.TruckId = foodTruck1;
            review2.TruckId = foodTruck1;
            review3.TruckId = foodTruck1;
            review4.TruckId = foodTruck2;
            review5.TruckId = foodTruck2;
            review6.TruckId = foodTruck2;
            review7.TruckId = foodTruck3;
            review8.TruckId = foodTruck3;
            review9.TruckId = foodTruck3;
            review10.TruckId = foodTruck4;
            review11.TruckId = foodTruck4;
            review12.TruckId = foodTruck4;
            review13.TruckId = foodTruck5;
            review14.TruckId = foodTruck5;
            review15.TruckId = foodTruck5;
            review16.TruckId = foodTruck5;
            review17.TruckId = foodTruck5;
            review18.TruckId = foodTruck6;
            review19.TruckId = foodTruck6;
            review20.TruckId = foodTruck6;

            menuItem1.FoodTruck = foodTruck1;
            menuItem2.FoodTruck = foodTruck1;
            menuItem3.FoodTruck = foodTruck1;
            menuItem4.FoodTruck = foodTruck1;
            menuItem5.FoodTruck=foodTruck2;
            menuItem6.FoodTruck = foodTruck2;
            menuItem7.FoodTruck=foodTruck3;
            menuItem8.FoodTruck = foodTruck3;
            menuItem9.FoodTruck = foodTruck3;
            menuItem10.FoodTruck = foodTruck3;
            menuItem11.FoodTruck = foodTruck4;
            menuItem12.FoodTruck = foodTruck4;
            menuItem13.FoodTruck = foodTruck5;
            menuItem14.FoodTruck = foodTruck5;
            menuItem15.FoodTruck = foodTruck6;
            menuItem16.FoodTruck = foodTruck6;

            context.SaveChanges();
        }
    }
}
