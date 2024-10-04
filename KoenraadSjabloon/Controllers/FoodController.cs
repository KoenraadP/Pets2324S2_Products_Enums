using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pets.Bll;
using Pets.Entities;

namespace KoenraadSjabloon.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index()
        {
            return View(Foods.Read());
        }

        public ActionResult DogFoodIndex()
        {
            return View(Foods.DogFoods());
        }

        public ActionResult CatFoodIndex()
        {
            return View(Foods.CatFoods());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string description, Animal animal, Brand brand, decimal price)
        {
            Foods.Create(name, description, animal, brand, price);

            return View();
        }
    }
}