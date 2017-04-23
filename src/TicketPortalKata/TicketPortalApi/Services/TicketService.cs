namespace TicketPortalApi.Services
{
    using System;
    using System.Threading.Tasks;
    using Models;
    using Repositories;

    public interface ITicketService {
        Task BuyTicket(Ticket ticket);
    }

    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            if (ticketRepository == null) { throw new ArgumentNullException(nameof(ticketRepository)); }
            _ticketRepository = ticketRepository;
        }

        public async Task BuyTicket(Ticket ticket)
        {
            if (ticket == null) { throw new ArgumentNullException(nameof(ticket)); }
            await _ticketRepository.SaveTicket(ticket);
        }
    }
}