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
        public static DateTime ReservationDateTime = new DateTime(2017, 4, 30, 18, 0, 0);
        public const int SeatNumber = 5;

        public static Ticket CreateTicket()
        {
            return new Ticket()
                   {
                       CustomerName = CustomerName,
                       MovieName = MovieName,
                       MovieTheater = MovieTheater,
                       ReservationDateTime = ReservationDateTime,
                       SeatNumber = SeatNumber
                   };
        }
    }
}
