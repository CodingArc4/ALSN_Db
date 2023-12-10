using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace ALSN.Domain.Models { 
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public int CountryId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockOutEnd { get; set; }
        public int AccessedFailedCount { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }

        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
