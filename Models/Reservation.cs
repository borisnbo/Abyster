namespace Abyster.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ParkingId { get; set; }
        public int TicketId { get; set; }
        public Parking Parking { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
    }
}
