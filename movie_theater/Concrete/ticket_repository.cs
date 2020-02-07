using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_theater.Data;
using movie_theater.iRepository;
using movie_theater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_theater.Repository
{
    public class ticket_repository : IticketRepository 
    {
        private readonly MovieTheaterContext _context;

        public ticket_repository(MovieTheaterContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ticket>> GetTicket()
        {
            return await _context.Ticket.ToListAsync();
        }
    }
}
