using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Document { get; set; }
        public DateTime Timestamp { get; set; }
        public int NoOfWords { get; set; }
        public bool IsFreeAmendments { get; set; }
        public bool IsPaid { get; set; }
        public int PaymentAmount { get; set; }
        public int SourceLanguageId { get; set; }
        public int TargetLanguageId { get; set; }
        public int OrderRepitionId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("SourceLanguageId")]

        public Language SourceLanguage { get; set; }
        [ForeignKey("TargetLanguageId")]

        public Language TargetLanguage { get; set; }
        [ForeignKey("OrderRepitionId")]

        public OrderRepition OrderRepition { get; set; }
    }
}
