using Consecionaria.Models;
using Consecionaria.Models.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consecionaria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var homeModel = new HomeViewModel();

            var fordKA = new Auto
            {
                Marca = "KA",
                Año = "2010",
                KM = 10000,
                Puertas = 4
            };

            var sedan = new Auto
            {
                Marca = "Sedan",
                Año = "2016",
                KM = 0,
                Puertas = 2
            };

            homeModel.Autos.Add(fordKA);
            homeModel.Autos.Add(sedan);

            return View(homeModel);
        }
    }
}