using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Ticket
    {
        [Key]
        public long TicketID { get; set; }
        public long GuestID { get; set; }
        public long AdminID { get; set; }
        public long OrderID { get; set; }
        public string Subject { get; set; }
        public string Attachment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }

        public User Guest { get; set; }
        public User Admin { get; set; }
        public Order Order { get; set; }
    }
}
