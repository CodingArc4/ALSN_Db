using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        public string PaymentTypeTitle { get; set; }
    }
}
