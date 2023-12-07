using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modules { get; set; }
    }
}
