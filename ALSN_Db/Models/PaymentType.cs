using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class PaymentType
    {
        [Key]
        public long PaymentTypeID { get; set; }
        public string PaymentTypeTitle { get; set; }
    }
}
