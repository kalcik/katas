using System.Threading.Tasks;

namespace TicketPortal.Tests
{
    using System.Data.Entity;
    using System.Diagnostics.CodeAnalysis;
    using TicketPortalApi.Models;
    using TicketPortalApi.Repositories;

    [ExcludeFromCodeCoverage]
    internal static class DbHelper
    {
        private static readonly TicketPortalDb TicketPortalDb;

        static DbHelper()
        {
            TicketPortalDb = new TicketPortalDb();
        }

        public static async Task<bool> ExistsOnce(Ticket ticket)
        {
            int count = await TicketPortalDb.Tickets
                                      .CountAsync(ticketToSearch =>
                                                     ticketToSearch.CustomerName == ticket.CustomerName
                                                  && ticketToSearch.MovieName == ticket.MovieName
                                                  && ticketToSearch.MovieTheater == ticket.MovieTheater
                                                  && ticketToSearch.SeatNumber == ticket.SeatNumber);

            return count == 1;
        }

        public static async Task DeleteTicket(Ticket ticket)
        {
            var foundTicket = await TicketPortalDb.Tickets.SingleOrDefaultAsync(ticketToSearch =>
                                                                              ticketToSearch.CustomerName == ticket.CustomerName
                                                                           && ticketToSearch.MovieName == ticket.MovieName
                                                                           && ticketToSearch.MovieTheater == ticket.MovieTheater
                                                                           && ticketToSearch.SeatNumber == ticket.SeatNumber);
            TicketPortalDb.Tickets.Remove(foundTicket);
            await TicketPortalDb.SaveChangesAsync();
        }
    }
}
