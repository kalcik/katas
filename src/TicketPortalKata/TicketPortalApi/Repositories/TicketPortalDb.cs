namespace TicketPortalApi.Repositories
{
    using System.Data.Entity;
    using Models;

    public class TicketPortalDb : DbContext
    {
        public TicketPortalDb() : base("TicketPortalDb") { }

        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}