using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Room_Reservation
    {
        [Key]
        public Guid reservationId { get; set; }

        [ForeignKey("RoomId")]
        public Guid RoomId { get; set; }

        public DateTime Checkin_Time { get; set; }
        public DateTime Checkout_Time { get; set; }
        public int Number_of_Guests { get; set; }
        [ForeignKey("GuestId")]
        public Guid GuestsId { get; set; }
    }
}
