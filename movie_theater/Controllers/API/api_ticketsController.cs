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

        #region
        //private readonly MovieTheaterContext _context;

        //public api_ticketsController(MovieTheaterContext context)
        //{
        //    _context = context;
        //}

        //// GET: api/api_tickets
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Ticket>>> GetTicket()
        //{
        //    return await _context.Ticket.ToListAsync();
        //}

        //// GET: api/api_tickets/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Ticket>> GetTicket(int id)
        //{
        //    var ticket = await _context.Ticket.FindAsync(id);

        //    if (ticket == null)
        //    {
        //        return NotFound();
        //    }

        //    return ticket;
        //}

        // PUT: api/api_tickets/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTicket(int id, Ticket ticket)
        //{
        //    if (id != ticket.TicketId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(ticket).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TicketExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/api_tickets
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Ticket>> PostTicket(Ticket ticket)
        //{
        //    _context.Ticket.Add(ticket);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (TicketExists(ticket.TicketId))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetTicket", new { id = ticket.TicketId }, ticket);
        //}

        //// DELETE: api/api_tickets/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Ticket>> DeleteTicket(int id)
        //{
        //    var ticket = await _context.Ticket.FindAsync(id);
        //    if (ticket == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Ticket.Remove(ticket);
        //    await _context.SaveChangesAsync();

        //    return ticket;
        //}

        //private bool TicketExists(int id)
        //{
        //    return _context.Ticket.Any(e => e.TicketId == id);
        //}
        #endregion
    }
}
