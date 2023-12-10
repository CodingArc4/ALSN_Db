using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string UserTypeTitle { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string LanguageExpertise { get; set; }
        public string Status { get; set; }
        public string CompanyName { get; set; }
    }
}
