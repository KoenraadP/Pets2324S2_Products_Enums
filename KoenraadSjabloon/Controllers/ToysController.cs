using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pets.Bll;
using Pets.Entities;

namespace KoenraadSjabloon.Controllers
{
    public class ToysController : Controller
    {
        // GET: Toys
        public ActionResult Index()
        {
            return View(Toys.Read());
        }

        public ActionResult DogToyIndex()
        {
            return View(Toys.DogToys());
        }

        public ActionResult CatToyIndex()
        {
            return View(Toys.CatToys());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string description, Animal animal, Brand brand, decimal price)
        {
            Toys.Create(name, description, animal, brand, price);

            return View();
        }
    }
}