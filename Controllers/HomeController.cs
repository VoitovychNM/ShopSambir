using Microsoft.AspNetCore.Mvc;
using ShopSambir.Data.Interfaces;
using ShopSambir.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }


        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            

            ViewBag.Title = "Store with car";
            return View(homeCars);
        }




    }
}
