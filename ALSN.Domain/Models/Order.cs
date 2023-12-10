using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int GuestId { get; set; }
        public  int TranslationOfficeId { get; set; }
        public string DocumentType { get; set; }
        public string AttachmentDocument { get; set; }
        public decimal CommissionAmount { get; set; }
        public string Status { get; set; }

        [ForeignKey("GuestId")]
        public User Guest { get; set; }
        [ForeignKey("TranslationOfficeId")]
        public UserBank TranslationOffice { get; set; }
    }
}
