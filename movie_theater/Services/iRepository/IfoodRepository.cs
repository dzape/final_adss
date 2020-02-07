﻿using movie_theater.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace movie_theater.iRepository
{
    public interface IfoodRepository
    {
        Task<IEnumerable<FoodItem>> GetFoodItems();

    }
}
