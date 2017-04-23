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
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class TicketRepositoryTests
    {
        [Fact]
        public void SaveTicketIsCorrect()
        {
            var ticket = TicketHelper.CreateTicket();
            var ticketPortalDbMock = new Mock<TicketPortalDb>();
            ticketPortalDbMock.Setup(ticketPortalDb => ticketPortalDb.Tickets.Add(ticket)).Verifiable();

            var sut = new TicketRepository(ticketPortalDbMock.Object);

            Func<Task> sutInvoke = async () => await sut.SaveTicket(ticket);
            sutInvoke.ShouldNotThrow();
            ticketPortalDbMock.Verify(dbCall => dbCall.Tickets.Add(ticket), Times.Once());
            ticketPortalDbMock.Verify(dbCall => dbCall.SaveChangesAsync(), Times.Once());
        }
    }
}