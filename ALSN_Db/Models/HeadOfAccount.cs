using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class HeadOfAccount
    {
        [Key]
        public long HeadOfAccountID { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string ParentAccount { get; set; }
        public DateTime ValidityFrom { get; set; }
        public DateTime ValidityTo { get; set; }
    }
}
