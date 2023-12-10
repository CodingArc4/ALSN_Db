using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class HeadOfAccount
    {
        [Key]
        public int HeadOfAccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string ParentAccount { get; set; }
        public DateTime ValidityFrom { get; set; }
        public DateTime ValidityTo { get; set; }
    }
}
