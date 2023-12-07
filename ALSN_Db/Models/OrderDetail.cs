using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class OrderDetail
    {
        [Key]
        public long OrderDetailID { get; set; }
        public long OrderID { get; set; }
        public string Document { get; set; }
        public DateTime Timestamp { get; set; }
        public long NoOfWords { get; set; }
        public bool IsFreeAmendments { get; set; }
        public bool IsPaid { get; set; }
        public long PaymentAmount { get; set; }
        public int SourceLanguageID { get; set; }
        public int TargetLanguageID { get; set; }
        public int OrderRepitionID { get; set; }

        public Order Order { get; set; }
        public Language SourceLanguage { get; set; }
        public Language TargetLanguage { get; set; }
        public OrderRepition OrderRepition { get; set; }
    }
}
