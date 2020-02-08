using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie_theater.iRepository;
using movie_theater.Models;

namespace movie_theaater.Controllers.api_controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class api_ticketsController : ControllerBase
    {
        private readonly IticketRepository _ticket;

        public api_ticketsController(IticketRepository ticket)
        {
            _ticket = ticket;
        }

        // GET: api/index
        [HttpGet]
        public async Task<IEnumerable<Ticket>> GetTicket()
        {

            return await _ticket.GetTicket();
        }
    }
}
