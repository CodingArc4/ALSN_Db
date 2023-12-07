using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Order
    {
        [Key]
        public long OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public long GuestID { get; set; }
        public long TranslationOfficeID { get; set; }
        public string DocumentType { get; set; }
        public string AttachmentDocument { get; set; }
        public decimal CommissionAmount { get; set; }
        public string Status { get; set; }

        public User Guest { get; set; }
        public User TranslationOffice { get; set; }
    }
}
