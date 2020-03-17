using ShopSambir.Data.Interfaces;
using ShopSambir.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Electro Car", desc = "car for future" },
                    new Category { categoryName = "Classic Car", desc = "old car"}
                };
            }
        }
    }
}
