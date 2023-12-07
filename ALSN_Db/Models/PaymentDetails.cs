using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class PaymentDetails
    {
        [Key]
        public long PaymentDetailID { get; set; }
        public long PaymentID { get; set; }
        public long HeadOfAccountID { get; set; }
        public long Debit { get; set; }
        public long Credit { get; set; }

        public Payment Payment { get; set; }
        public HeadOfAccount HeadOfAccount { get; set; }
    }
}
