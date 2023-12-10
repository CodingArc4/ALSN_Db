using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int AdminId { get; set; }
        public string Narration { get; set; }
        public int PartyId { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderId { get; set; }
        public string PaymentStatus { get; set; }

        [ForeignKey("AdminId")]
        public User Admin { get; set; }
        [ForeignKey("PartyId")]
        public User Party { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
    }
}
