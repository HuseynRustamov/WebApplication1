using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="NZS 1 manat",
                    ImagePath="images/pive.jpg"
                },

                 new Drink
                {
                    Id=2,
                    Name="Jack Daniels 50 gram",
                    ImagePath="images/jackdaniels.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Kvas Elxan ucun",
                    ImagePath="images/kvas.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Tequila Omega mellim ucun",
                    ImagePath="images/omega.png"
                }

            };
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Food",
                    ImagePath="images/food.jpg"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Food",
                    ImagePath="images/food2.jpg"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Food",
                    ImagePath="images/food3.png"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Food",
                    ImagePath="images/food4.jpg"
                }

            };
            List<FastFood> fastFoods = new List<FastFood>
            {
              new FastFood
                {
                    Id=1,
                    Name="FastFood",
                    ImagePath="../images/food.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="FastFood",
                    ImagePath="../images/food2.jpg"
                },
                new FastFood
                {
                    Id=3,
                    Name="FastFood",
                    ImagePath="../images/food3.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="FastFood",
                    ImagePath="../images/food4.jpg"
                }
            };
            var model = new MenuListViewModel
            {
                Drinks=drinks,
                HotMeals=hotMeals,
                FastFoods=fastFoods      
            };
            return View(model);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                 new Drink
                {
                    Id=1,
                    Name="NZS 1 manat",
                    ImagePath="images/pive.jpg"
                },

                 new Drink
                {
                    Id=2,
                    Name="Jack Daniels 50 gram",
                    ImagePath="images/jackdaniels.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Kvas Elxan ucun",
                    ImagePath="images/kvas.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Tequila Omega mellim ucun",
                    ImagePath="images/omega.png"
                }

            };

            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                 new HotMeal
                {
                    Id=1,
                    Name="Food",
                    ImagePath="images/food.jpg"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Food",
                    ImagePath="images/food2.jpg"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Food",
                    ImagePath="images/food3.png"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Food",
                    ImagePath="images/food4.jpg"
                }

            };
            return View(hotMeals);
        }

        public IActionResult FastFood()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="FastFood",
                    ImagePath="../images/food.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="FastFood",
                    ImagePath="../images/food2.jpg"
                },
                new FastFood
                {
                    Id=3,
                    Name="FastFood",
                    ImagePath="../images/food3.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="FastFood",
                    ImagePath="../images/food4.jpg"
                }
            };
            return View(fastFoods);

        }
    }
}
