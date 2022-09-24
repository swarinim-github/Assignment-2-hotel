using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management_System.Models
{
    public class Bill
    {
        public Guid BillId { get; set; }
        [ForeignKey("GuestId")]
        public Guid GuestId { get; set; }
        public float Amount { get; set; }
        public DateTime BillDate { get; set; }
        [ForeignKey("reservationId")]
        public Guid reservationId { get; set; }

    }
}
