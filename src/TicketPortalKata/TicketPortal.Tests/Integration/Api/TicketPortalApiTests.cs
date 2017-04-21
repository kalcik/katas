namespace TicketPortal.Tests.Integration.Api
{
    using System;
    using FluentAssertions;
    using RestSharp;
    using TicketPortalApi.Models;
    using Xunit;

    public class TicketPortalApiTests
    {
        [Fact]
        public void TicketBuyIsCorrect()
        {
            var request = new RestRequest
                          {
                              RequestFormat = DataFormat.Json,
                              Resource = "Ticket",
                              Method = Method.POST
                          };
            var ticket = new Ticket
                         {
                             CustomerName = "SampleCustomerName",
                             Movie = "SampleMovie",
                             MovieTheater = "SampleMovieTheater",
                             ReservationDateTime = new DateTime(2017, 4, 30, 18, 0, 0),
                             SeatNumber = 5
                         };
            request.AddBody(ticket);

            var restClient = new RestClient("http://neo:24280");
            var response = restClient.Execute(request);

            response.StatusCode.Should().Be(200);
        }
    }
}