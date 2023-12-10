using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int GuestId { get; set; }
        public int AdminId { get; set; }
        public int OrderId { get; set; }
        public string Subject { get; set; }
        public string Attachment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("GuestId")]
        public User Guest { get; set; }
        [ForeignKey("AdminId")]
        public User Admin { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
