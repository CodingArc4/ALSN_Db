using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modules { get; set; }
    }
}
