using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class OrderAssignment
    {
        [Key]
        public long OrderAssignementID { get; set; }
        public long OrderID { get; set; }
        public long TranslatorID { get; set; }

        public Order Order { get; set; }
        public User Translator { get; set; }
    }
}
