using Microsoft.AspNetCore.Mvc;
using ShopSambir.Data.Interfaces;
using ShopSambir.Data.Models;
using ShopSambir.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShopSambir.Controllers
{
    public class CarsController: Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]

        public ViewResult List(string category) 
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase ))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Electro car")).OrderBy(i => i.id);

                    currCategory = "Electro car";
                }
                else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Classic car")).OrderBy(i => i.id);

                    currCategory = "Classic car";
                }


              

            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };


            ViewBag.Title = "Store with car";
          
            return View(carObj);
        }
    }

}
