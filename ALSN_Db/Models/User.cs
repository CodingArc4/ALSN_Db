using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ALSN_Db.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }
        public int UserTypeID { get; set; }
        public int CountryID { get; set; }
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

        public UserType UserType { get; set; }
        public Country Country { get; set; }
    }
}
