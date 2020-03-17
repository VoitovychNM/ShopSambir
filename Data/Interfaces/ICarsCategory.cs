﻿using ShopSambir.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSambir.Data.Interfaces
{
   public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
