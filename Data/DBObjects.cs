using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopSambir.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }


            if (!content.Car.Any())
            {
                content.AddRange(

                     new Car
                     {
                         name = "Tesla model S",
                         shortDesc = "Швидка машина",
                         longDesc = "Красива машина компанії тесла",
                         img = "/img/Tesla.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Electro car"]
                     },
                    new Car
                    {
                        name = "BMW X5M",
                        shortDesc = "Крута машина",
                        longDesc = "Блатний бумер",
                        img = "/img/Bmw.jpg",
                        price = 5000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Lexus LX450",
                        shortDesc = "Япончик",
                        longDesc = "японський мерседес",
                        img = "/img/Lexus.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Classic car"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "електричне такс",
                        longDesc = "коли на теслу не хватило",
                        img = "/img/Leaf.jpg",
                        price = 3000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electro car"]
                    },
                     new Car
                     {
                         name = "Ford focus",
                         shortDesc = "Швидка машина",
                         longDesc = "Красива машина компанії тесла",
                         img = "/img/focus.jpg",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Classic car"]
                     },
                      new Car
                      {
                          name = "Volkswagen Golf gti",
                          shortDesc = "Швидка машина",
                          longDesc = "Красива машина компанії тесла",
                          img = "/img/golf.jpg",
                          price = 500,
                          isFavourite = false,
                          available = true,
                          Category = Categories["Classic car"]
                      },
                       new Car
                       {
                           name = "Cadillac Escalade",
                           shortDesc = "Швидка машина",
                           longDesc = "Красива машина компанії тесла",
                           img = "/img/Cadillac.jpg",
                           price = 45000,
                           isFavourite = true,
                           available = true,
                           Category = Categories["Classic car"]
                       },
                        new Car
                        {
                            name = "Porsche panamera",
                            shortDesc = "Швидка машина",
                            longDesc = "Красива машина компанії тесла",
                            img = "/img/Porsche.jpg",
                            price = 45000,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Classic car"]
                        },
                       new Car
                       {
                           name = "Mercedes-Benz Gle coupe",
                           shortDesc = "Модна машина",
                           longDesc = "машина для голови колгоспу",
                           img = "/img/Mercedes.jpg",
                           price = 9500,
                           isFavourite = true,
                           available = true,
                           Category = Categories["Classic car"]
                       }

                    ) ;
            }

            content.SaveChanges();

        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(category==null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Electro car", desc = "car for future" },
                         new Category { categoryName = "Classic car", desc = "old car"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }

    }
}
