namespace TicketPortalApi.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Models;
    using Services;

    public class TicketController : ApiController
    {
        public async Task<IHttpActionResult> Post([FromBody] Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}