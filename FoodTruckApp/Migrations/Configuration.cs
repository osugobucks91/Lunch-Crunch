namespace FoodTruckApp.Migrations
{
    using Domain.Models;
    using Infrastructure;
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
            var bellyupReviews = new Review[]
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
                }

            };

            var dasmanReviews = new Review[]
            {
                new Review
                {
                    Id=1,
                    StarRating=5,
                    Message="Been to all four corners of the states and by far the best most genuine authentic food is being served at dasman food truck, I can say that I  have finally found the home away from home reminds me of the shawerma in Damascus syria"
                },
                new Review
                {
                    Id=2,
                    StarRating=5,
                    Message="Best shawarma I ever had in two years, I wish the had a place I can take my family to"
                },
                new Review
                {
                    Id=3,
                    StarRating=3,
                    Message="Very slow in fulfilling orders and not very organized. Suggest some process to figure out the order in which people placed their orders and more efficiency in the kitchen. Shawerma wasn't that good."
                }

            };

            var stjohnReviews = new Review[]
            {
                new Review
                {
                    Id=1,
                    StarRating=5,
                    Message="I thought I had written a review for this truck, but it's not there anymore on yelp.  I've tried several of his dishes on multiple visits, and they're all really great.  Obviously the egg rolls are a must."
                },
                new Review
                {
                    Id=2,
                    StarRating=3,
                    Message="Skewered meats aren't exactly the type of food that you would expect to find off of a food truck, but that's exactly what St. John's Fire specializes in. I suppose that it makes sense that they could cook up these little meat popsicles since there a lot of BBQ places smoke their meats on pits attached to their food trucks. "
                },
                new Review
                {
                    Id=3,
                    StarRating=5,
                    Message="I have tremendous love for everything fried and battered that come out of this truck. They know how to do greasy food right."
                }
            };

            var berniesReviews = new Review[]
            {
                new Review
                {
                    Id=1,
                    StarRating=5,
                    Message="If you're a burger and fries person, you have got to try Bernie's Burger Bus!!  Their burgers are absolutely delicious and worth every single bite!! Oh and don't worry if you aren't a burger person, I peaked at the salad section on the menu and they sound really amazing too"
                },
                new Review
                {
                    Id=2,
                    StarRating=5,
                    Message="These are some of the most well made burgers I've had. The menu is based on school, and you sit at desks. The kitchen is a big yellow school bus, and the best part is, they have local Texas beer."
                },
                new Review
                {
                    Id=3,
                    StarRating=5,
                    Message="Wow is all I can say about this place. I read the reviews.  I did my research.  I knew it would be good.  I was still really impressed on how good it really was. "
                }
            };

            var skratchReviews = new Review[]
            {
                new Review
                {
                    Id=1,
                    StarRating=4,
                    Message="Omg I stumbled on this place at HEB Friday night and had their mushroom burger. I asked to add bacon and I think it seriously was the best burger I've had in ages."
                },
                new Review
                {
                    Id=2,
                    StarRating=5,
                    Message="Everything was absolutely delicious and it was all exceptionally reasonably priced! I could have bathed in the fries!"
                },
                new Review
                {
                    Id=3,
                    StarRating=4,
                    Message="This truck has it all.  Exceptional food, fast and friendly service, variety and big smiles!  They are an inspiration to other food trucks!"
                },
                new Review
                {
                    Id=3,
                    StarRating=5,
                    Message="This is the best food truck I've found in Houston. Though their food is heavy, it is always delicious.  I personally love the Lobster Roll. Think about it, who in the world would ever pay $15 for a sandwich off a truck? THIS GUY!!"
                },
                new Review
                {
                    Id=3,
                    StarRating=4,
                    Message="Just order the lobster roll. The bread is thick and buttered (like thick Texas toast), and the roll itself is filled with huge, tender pieces of fresh lobster."
                }

            };

            var wafflebusReviews = new Review[]
            {
                new Review
                {
                    Id=1,
                    StarRating=4,
                    Message="Delicious!  I had the fried chicken and waffle with a mix of spicy mayo and ancho chile honey and the flavor combination was awesome! "
                },
                new Review
                {
                    Id=2,
                    StarRating=3,
                    Message="I'll give it 3 stars cause I never wrote a review when it first started but when I first had it in 2013 it was amazing! "
                },
                new Review
                {
                    Id=3,
                    StarRating=4,
                    Message="It was my first time trying chicken and waffles. My boyfriend has raved about them for a while now. I was pretty anti-chicken and waffles but after a few drinks I figured I'd be a little adventurous and give them a try. "
                }
            };

            //***************************************

            var bellyupMenuItems = new MenuItem[]
            {
                new MenuItem
                {
                    Id=1,
                    Name="Potato Taco",
                    Price = 4.0m,
                    Description="tater tots, portabella-black bean salsa, piquillo peppers, salsa verde, feta, preserved lemon crema",
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
                }

            };

            var dasmanMenuItems = new MenuItem[]

            {
                new MenuItem
                {
                    Id=1,
                    Name="Chicken over rice",
                    Price = 10m,
                    Description="Chicken over rice",
                    ImageUrl="http://hostedmedia.reimanpub.com/TOH/Images/Photos/37/300x300/exps819_FFR1450842D18.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="Chicken shaurma",
                    Price=8m,
                    Description="Chicken shaurma",
                    ImageUrl="http://allthecooking.com/wp-content/uploads/2015/11/Chicken-Shawarma.jpg"
                }
            };

            var stjohnsMenuItems = new MenuItem[]
            {
                new MenuItem
                {
                    Id=1,
                    Name="Cajun Egg roll",
                    Price = 5m,
                    Description="shrimp, crawfish, tasso ham and guava mustard",
                    ImageUrl="http://cdn.recipes100.com/v/3956de0cf5e69a0dde9bb68fcddec86e.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="Hot and Crunchy Chicken Sandwich",
                    Price=8m,
                    Description="with fig preserves, applewood-smoked bacon and torched brie on chabatta bread",
                    ImageUrl="http://www.recipe.com/images/hot-and-crunchy-chicken-cones-1360-ss.jpg"
                },
                new MenuItem
                {
                    Id=3,
                    Name="Slow Roasted Pulled Pork Sandwich",
                    Price = 8m,
                    Description="lightly smoked pork with marinated slaw and Creole mustard on ciabatta bread",
                    ImageUrl="http://www.recipe.com/images/slow-cooked-pulled-pork-sandwiches-26160-ss.jpg"
                },
                new MenuItem
                {
                    Id=4,
                    Name="Tortilla Crusted Fish Tacos",
                    Price=8m,
                    Description="with marinated cabbage, pico de gallo and lime-cilantro rice",
                    ImageUrl="https://s-media-cache-ak0.pinimg.com/736x/29/e5/07/29e507aa543233426fac2a20de33ce2a.jpg"
                }
            };

            var berniesMenuItems = new MenuItem[]
            {
                new MenuItem
                {
                    Id=1,
                    Name="The principal",
                    Price = 9m,
                    Description="classic burger with a choice of cheese, all homemade mayonnaise, mustard, ketchup, thin sliced onions, pickles, shredded lettuce, and slow roasted garlic tomatoes",
                    ImageUrl="http://www.nancyskitchen.com/frenchs-mustard-recipes/Frenchs_Classic_Burgers.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="The cheerleader",
                    Price=10.25m,
                    Description="pepper jack cheeseburger, crisp y jalapenos, slow roasted garlic tomatoes, shredded lettuce, and jalapeno ranch",
                    ImageUrl="http://www.burgerweekly.com/wp-content/uploads/2014/01/IMG_0776-300x300.jpg"
                }
            };

            var skratchMenuItems = new MenuItem[]
            {
                new MenuItem
                {
                    Id=1,
                    Name="Lobster Roll",
                    Price = 15m,
                    Description="Live Maine Lobster Meat, Chives, Dill, Celery and Mayo",
                    ImageUrl="https://www.theinfatuation.com/wp-content/uploads/2015/08/Ruschmeyers-Montauk-Lobster-Roll-Photo-Credit-Ashley-Sears-300x300.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="Brazilian Steak Sandwich",
                    Price=10m,
                    Description="Shaved Rib Eye, Homemade Chimichuri, Shaved Red Onions on Hoggie Roll",
                    ImageUrl="http://www.recipe.com/images/cajun-steak-sandwich-with-sweet-potato-fries-R145148-ss.jpg"
                }
            };

            var wafflebusMenuItems = new MenuItem[]
            {
                new MenuItem
                {
                    Id=1,
                    Name="Waffle Burger",
                    Price = 8m,
                    Description="Quarter pound beef patty with American cheese, crisp romain lettuce",
                    ImageUrl="http://www.lamag.com/wp-content/uploads/sites/9/2015/10/WaffleSando-300x300.jpg"
                },
                new MenuItem
                {
                    Id=2,
                    Name="Smoked Salmon Waffle",
                    Price=8m,
                    Description="With lemon, organic baby spinach, sliced tomatos",
                    ImageUrl="http://secretlifeoffatbacks.com/wp-content/uploads/2015/03/IMG_5760-300x300.jpg"
                }
            };

            var foodTrucks = new FoodTruck[]
            {
                new FoodTruck
                {
                    Id=1,
                    Name = "Belly Up",
                    Image = "https://www.foodtrucksin.com/sites/default/files/styles/truck_food_gallery/public/20150429_110901.jpg?itok=ur2nK19w",
                    Description = "Belly Up is proud to serve American cuisine with ethnic twists",
                    Location = "1234 Montrose St, Houston, TX 77019"
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


            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            var test = userManager.FindByName("Test");
            if (test == null)
            {
                test = new ApplicationUser()
                {
                    UserName = "test",
                    Email = "test@test.com"
                };
                userManager.Create(test, "Password!1");
            }

            var business = userManager.FindByName("business@business.com");

            if (business == null)
            {
                business = new ApplicationUser()
                {
                    UserName = "business@business.com",
                    Email = "business@business.com",
                };
                userManager.Create(business, "Password!1");
            };

            var jacobbelly = userManager.FindByName("jacob.belly@gmail.com");
            if (jacobbelly == null)
            {
                jacobbelly = new ApplicationUser()
                {
                    UserName = "jacob.belly@gmail.com",
                    Email = "jacob.belly@gmail.com"
                };
                userManager.Create(jacobbelly, "Password!1");
            }

            var ismaildasman = userManager.FindByName("ismail.dasman@gmail.com");
            if (ismaildasman == null)
            {
                ismaildasman = new ApplicationUser()
                {
                    UserName = "ismail.dasman@gmail.com",
                    Email = "ismail.dasman@gmail.com"
                };
                userManager.Create(ismaildasman, "Password!1");
            }

            var john = userManager.FindByName("john.saint@gmail.com");
            if (john == null)
            {
                john = new ApplicationUser()
                {
                    UserName = "john.saint@gmail.com",
                    Email = "john.saint@gmail.com"
                };
                userManager.Create(john, "Password!1");
            }

            var bernie = userManager.FindByName("bernie.smith@gmail.com");
            if (bernie == null)
            {
                bernie = new ApplicationUser()
                {
                    UserName = "bernie.smith@gmail.com",
                    Email = "bernie.smith@gmail.com"
                };
                userManager.Create(bernie, "Password!1");
            }

            var gregskratch = userManager.FindByName("greg.skratch@gmail.com");
            if (gregskratch == null)
            {
                gregskratch = new ApplicationUser()
                {
                    UserName = "greg.skratch@gmail.com",
                    Email = "greg.skratch@gmail.com"
                };
                userManager.Create(gregskratch, "Password!1");
            }

            var bobwaffle = userManager.FindByName("bob.waffle@gmail.com");
            if (bobwaffle == null)
            {
                bobwaffle = new ApplicationUser()
                {
                    UserName = "bob.waffle@gmail.com",
                    Email = "bob.waffle@gmail.com"
                };
                userManager.Create(bobwaffle, "Password!1");
            }

            context.SaveChanges();
        }
    }
}
