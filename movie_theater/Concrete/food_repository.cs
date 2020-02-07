using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using movie_theater.Data;
using movie_theater.Models;
using Microsoft.EntityFrameworkCore;

namespace movie_theater.Repository
{
    public class food_repository 
    {
        private readonly MovieTheaterContext _context;

        // GET: api/api_fooditem

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItem()
        {
            return await _context.FoodItem.ToListAsync();
        }
    }
}
