using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class UserBank
    {
        [Key]
        public long BankID { get; set; }
        public long UserID { get; set; }
        public long TranslationOfficeID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public string BranchAddress { get; set; }

        public User User { get; set; }
    }
}
