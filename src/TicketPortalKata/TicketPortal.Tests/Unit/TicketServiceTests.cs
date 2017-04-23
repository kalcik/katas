namespace TicketPortal.Tests.Unit
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Moq;
    using TicketPortalApi.Models;
    using TicketPortalApi.Repositories;
    using TicketPortalApi.Services;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class TicketServiceTests
    {
        [Fact]
        public void TicketBuyIsCorrect()
        {
            var ticket = new Ticket
                         {
                             CustomerName = "SampleCustomerName",
                             Movie = "SampleMovie",
                             MovieTheater = "SampleMovieTheater",
                             ReservationDateTime = new DateTime(2017, 4, 30, 18, 0, 0),
                             SeatNumber = 5
                         };

            var tickets = new List<Ticket>
                          {
                              ticket
                          }.AsQueryable();

            var ticketsMock = new Mock<DbSet<Ticket>>();
            ticketsMock.As<IQueryable<Ticket>>().Setup(m => m.Provider).Returns(tickets.Provider);
            ticketsMock.As<IQueryable<Ticket>>().Setup(m => m.Expression).Returns(tickets.Expression);
            ticketsMock.As<IQueryable<Ticket>>().Setup(m => m.ElementType).Returns(tickets.ElementType);
            ticketsMock.As<IQueryable<Ticket>>().Setup(m => m.GetEnumerator()).Returns(() => tickets.GetEnumerator());

            var ticketPortalDbMock = new Mock<TicketPortalDb>();
            ticketPortalDbMock.Setup(ticketPortalDb => ticketPortalDb.Tickets)
                              .Returns(ticketsMock.Object);

            var sut = new TicketService(ticketPortalDbMock.Object);
            Func<Task> sutInvoke = async () => await sut.BuyTicket(ticket);
            sutInvoke.ShouldNotThrow();
            ticketPortalDbMock.Verify(dbCall => dbCall.Tickets, Times.Once());
        }
    }
}