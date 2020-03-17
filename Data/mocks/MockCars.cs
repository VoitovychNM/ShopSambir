using ShopSambir.Data.Interfaces;
using ShopSambir.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();


        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla model S",
                        shortDesc = "Швидка машина",
                        longDesc = "Красива машина компанії тесла",
                        img = "/img/Tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "BMW X5M",
                        shortDesc = "Крута машина",
                        longDesc = "Блатний бумер",
                        img = "/img/Bmw.jpg",
                        price = 5000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Lexus LX450",
                        shortDesc = "Япончик",
                        longDesc = "японський мерседес",
                        img = "/img/Lexus.jpg",
                        price = 55000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "електричне такс",
                        longDesc = "коли на теслу не хватило",
                        img = "/img/Leaf.jpg",
                        price = 3000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car
                    {
                        name = "Ford focus",
                        shortDesc = "Швидка машина",
                        longDesc = "Красива машина компанії тесла",
                        img = "/img/focus.jpg",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                      new Car
                    {
                        name = "Volkswagen Golf gti",
                        shortDesc = "Швидка машина",
                        longDesc = "Красива машина компанії тесла",
                        img = "/img/golf.jpg",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                       new Car
                    {
                        name = "Cadillac Escalade",
                        shortDesc = "Швидка машина",
                        longDesc = "Красива машина компанії тесла",
                        img = "/img/Cadillac.jpg",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                        new Car
                    {
                        name = "Porsche panamera",
                        shortDesc = "Швидка машина",
                        longDesc = "Красива машина компанії тесла",
                        img = "/img/Porsche.jpg",
                        price = 45000,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                       new Car
                    {
                        name = "Mercedes-Benz Gle coupe",
                        shortDesc = "Модна машина",
                        longDesc = "машина для голови колгоспу",
                        img = "/img/Mercedes.jpg",
                        price = 9500,
                        isFavourite = true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last()
                    }


                };
            }
        }



        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
