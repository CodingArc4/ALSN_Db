using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class OrderPayment
    {
        [Key]
        public long PaymentID { get; set; }
        public long OrderID { get; set; }
        public long GuestID { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Order Order { get; set; }
        public User Guest { get; set; }
    }
}
