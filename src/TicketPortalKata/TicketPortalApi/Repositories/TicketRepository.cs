namespace TicketPortalApi.Repositories
{
    using System.Threading.Tasks;
    using Models;

    public interface ITicketRepository
    {
         Task SaveTicket(Ticket ticket);
    }

    public class TicketRepository : ITicketRepository
    {
        private readonly TicketPortalDb _database;

        public TicketRepository(TicketPortalDb database)
        {
            _database = database;
        }

        public async Task SaveTicket(Ticket ticket)
        {
            _database.Tickets.Add(ticket);
            await _database.SaveChangesAsync();
        }
    }
}