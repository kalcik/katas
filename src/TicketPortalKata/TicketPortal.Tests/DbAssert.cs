using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPortal.Tests
{
    using TicketPortalApi.Models;
    using TicketPortalApi.Repositories;

    public class DbAssert
    {
        public bool ExistsOnce(Ticket ticket)
        {
            var ticketPortalDb = new TicketPortalDb();
            int count = ticketPortalDb.Tickets
                                      .Count(ticketToSearch => ticketToSearch.ReservationDateTime == ticket.ReservationDateTime
                                      && ticketToSearch.CustomerName == ticket.CustomerName
                                      && ticketToSearch.Movie == ticket.Movie
                                      && ticketToSearch.MovieTheater == ticket.MovieTheater
                                      && ticketToSearch.SeatNumber == ticket.SeatNumber);

            return count == 1;
        }
    }
}
