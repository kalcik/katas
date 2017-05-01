namespace TicketPortalApi.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Ticket
    {
        public int Id { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public string MovieName { get; set; }
        [DataMember]
        public string MovieTheater { get; set; }
        [DataMember]
        public int SeatNumber { get; set; }
    }
}