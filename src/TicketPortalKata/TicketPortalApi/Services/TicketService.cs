namespace TicketPortalApi.Services
{
    using System;
    using System.Threading.Tasks;
    using Models;
    using Repositories;

    public class TicketService
    {
        private readonly TicketPortalDb _database;

        public TicketService(TicketPortalDb database)
        {
            if (database == null) { throw new ArgumentNullException(nameof(database)); }
            _database = database;
        }

        public async Task BuyTicket(Ticket ticket)
        {
            if (ticket == null) { throw new ArgumentNullException(nameof(ticket)); }
            _database.Tickets.Add(ticket);
            await _database.SaveChangesAsync();
        }
    }
}