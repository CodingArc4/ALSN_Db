using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class UserRole
    {
        [Key]
        public long UserID { get; set; }
        public int RoleID { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}
