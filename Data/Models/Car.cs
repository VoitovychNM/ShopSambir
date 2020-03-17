using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data.Models
{
   //створюючи один об'єкт цього класу ми створимо один товар на сайті

    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; } // короткий опис
        public string longDesc { set; get; } // Довгий опис
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }


    }
}
