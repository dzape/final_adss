using Microsoft.EntityFrameworkCore;
using movie_theater.Data;
using movie_theater.iRepository;
using movie_theater.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace movie_theater.Repository
{
    public class ticket : IticketRepository 
    {
        private readonly MovieTheaterContext _context;

        public ticket(MovieTheaterContext context)
        {
            _context = context;
        }

        // api/api_tickets/GetTickets
        public async Task<IEnumerable<Ticket>> GetTicket()
        {
            return await _context.Ticket.ToListAsync();
        }

        public Task<IEnumerable<Ticket>> Profit()
        {
            //return (ticket.TicketQuantity * ticket.TicketSalePrice) - (ticket.TicketStudioCutPercentage * ticket.TicketQuantity * ticket.TicketSalePrice);

            throw new System.NotImplementedException();
        }
    }
}
