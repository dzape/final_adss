using System;
using System.Collections.Generic;

namespace movie_theater.Models
{
    public partial class Ticket
    {
        public int? TicketId { get; set; }
        public string TicketMovieName { get; set; }
        public decimal? TicketSalePrice { get; set; }
        public decimal? TicketStudioCutPercentage { get; set; }
        public int? TicketQuantity { get; set; }
        public decimal? TicketProfile { get; set; }
        public decimal? TicketProfilePerItem { get; set; }
    }
}
