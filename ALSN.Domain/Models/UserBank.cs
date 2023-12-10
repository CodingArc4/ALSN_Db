using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALSN.Domain.Models
{
    public class UserBank
    {
        [Key]
        public int BankId { get; set; }
        public int UserId { get; set; }
        public int TranslationOfficeId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
