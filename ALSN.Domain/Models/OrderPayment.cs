using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class OrderPayment
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int GuestId { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("GuestId")]
        public User Guest { get; set; }
    }
}
