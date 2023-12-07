using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Payment
    {
        [Key]
        public long PaymentID { get; set; }
        public long AdminID { get; set; }
        public string Narration { get; set; }
        public long PartyID { get; set; }
        public long PaymentTypeID { get; set; }
        public DateTime PaymentDate { get; set; }
        public long OrderID { get; set; }
        public string PaymentStatus { get; set; }

        public User Admin { get; set; }
        public User Party { get; set; }
        public Order Order { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
