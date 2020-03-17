using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data.Models
{
    // тут будуть міститься поля в які ми дальше зможемо записувати дані про
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }

        public List<Car> cars { set; get; } // бо одна категорія може містити багато машин
        
    }
}
