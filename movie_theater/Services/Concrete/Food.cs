using Microsoft.EntityFrameworkCore;
using movie_theater.Data;
using movie_theater.iRepository;
using movie_theater.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace movie_theater.Repository
{
    public class food : IfoodRepository
    {
        private readonly MovieTheaterContext _context;

        public food(MovieTheaterContext context)
        {
            _context = context;
        }

        // api/api_tickets/GetTickets
        public async Task<IEnumerable<FoodItem>> GetFoodItems()
        {
            return await _context.FoodItem.ToListAsync();
        }

    }
}
