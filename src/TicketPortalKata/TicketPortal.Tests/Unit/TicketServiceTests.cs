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
            var ticket = TicketHelper.CreateTicket();
            var ticketRepositoryMock = new Mock<ITicketRepository>();

            var sut = new TicketService(ticketRepositoryMock.Object);

            Func<Task> sutInvoke = async () => await sut.BuyTicket(ticket);
            sutInvoke.ShouldNotThrow();
            ticketRepositoryMock.Verify(dbCall => dbCall.SaveTicket(ticket), Times.Once());
        }
    }
}