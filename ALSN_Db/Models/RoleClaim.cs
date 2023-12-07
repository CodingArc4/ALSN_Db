using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class RoleClaim
    {
        [Key]
        public long ClaimsID { get; set; }
        public int RoleID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public Role Role { get; set; }
    }
}
