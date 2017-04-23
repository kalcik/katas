namespace TicketPortalApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Models;
    using Services;

    public class TicketController : ApiController
    {
        private readonly TicketService _ticketService;

        public TicketController(TicketService ticketService)
        {
            if (ticketService == null) { throw new ArgumentNullException(nameof(ticketService)); }
            _ticketService = ticketService;
        }

        // POST: api/Ticket
        public async Task<IHttpActionResult> Post([FromBody] Ticket ticket)
        {
            await _ticketService.BuyTicket(ticket);
            return Ok();
        }
    }
}