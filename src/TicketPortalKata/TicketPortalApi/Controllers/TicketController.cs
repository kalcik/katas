namespace TicketPortalApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Models;

    public class TicketController : ApiController
    {
        // POST: api/Ticket
        public async Task<IHttpActionResult> Post([FromBody] Ticket ticket)
        {
            throw new NotImplementedException();
        }

    }
}