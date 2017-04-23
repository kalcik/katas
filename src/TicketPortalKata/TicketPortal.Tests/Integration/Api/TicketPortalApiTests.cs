namespace TicketPortal.Tests.Integration.Api
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Threading.Tasks;
    using FluentAssertions;
    using RestSharp;
    using TicketPortalApi.Models;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class TicketPortalApiTests : IDisposable
    {
        readonly Ticket _ticketToBuy = new Ticket
                              {
                                  CustomerName = "SampleCustomerName",
                                  Movie = "SampleMovie",
                                  MovieTheater = "SampleMovieTheater",
                                  ReservationDateTime = new DateTime(2017, 4, 30, 18, 0, 0),
                                  SeatNumber = 5
                              };

        public void Dispose()
        {
            Task.WaitAll(DbHelper.DeleteTicket(_ticketToBuy));
        }

        [Fact]
        public async Task TicketBuyIsCorrect()
        {
            var request = new RestRequest
                          {
                              RequestFormat = DataFormat.Json,
                              Resource = "Ticket",
                              Method = Method.POST
                          };
            request.AddBody(_ticketToBuy);

            var restClient = new RestClient("http://localhost:24280");
            var response = restClient.Execute(request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var ticketExistsInStore = await DbHelper.ExistsOnce(_ticketToBuy);
            ticketExistsInStore.Should().BeTrue();
        }
    }
}