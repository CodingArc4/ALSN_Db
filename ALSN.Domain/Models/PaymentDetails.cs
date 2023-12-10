using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models { 
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailId { get; set; }
        public int PaymentId { get; set; }
        public int HeadOfAccountId { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }
        [ForeignKey("HeadOfAccountId")]
        public HeadOfAccount HeadOfAccount { get; set; }
    }
}
