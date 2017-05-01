using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPortal.Tests
{
    using System.Data.Entity;
    using TicketPortalApi.Models;

    internal static class TicketHelper
    {
        public const string CustomerName = "SampleCustomerName";
        public const string MovieName = "SampleMovieName";
        public const string MovieTheater = "SampleMovieTheater";
        public const int SeatNumber = 5;

        public static Ticket CreateTicket()
        {
            return new Ticket()
                   {
                       CustomerName = CustomerName,
                       MovieName = MovieName,
                       MovieTheater = MovieTheater,
                       SeatNumber = SeatNumber
                   };
        }
    }
}
