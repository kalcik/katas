namespace TicketPortalApi.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Ticket
    {
        public string Id { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string Movie { get; set; }
        [DataMember]
        public string MovieTheater { get; set; }
        [DataMember]
        public DateTime ReservationDateTime { get; set; }
        [DataMember]
        public int SeatNumber { get; set; }
    }
}