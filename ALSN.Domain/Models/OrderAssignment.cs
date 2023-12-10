using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class OrderAssignment
    {
        [Key]
        public int OrderAssignementId { get; set; }
        public int OrderId { get; set; }
        public int TranslatorId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("TranslatorId")]
        public User Translator { get; set; }
    }
}
