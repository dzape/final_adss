﻿using movie_theater.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace movie_theater.iRepository
{
    public interface IticketRepository
    {
        Task<IEnumerable<Ticket>> GetTicket();
        
        //Task<IActionResult> PutTicket(int id, Ticket ticket)


        //Task<IEnumerable<Ticket>> Profit(); // (Quantity * SalePrice) -(StudioCutPercentage * (Quantity * SalePrice)

    }
}
