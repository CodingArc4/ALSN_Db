using System.ComponentModel.DataAnnotations;

namespace ALSN.Domain.Models
{
    public class OrderRepition
    {
        [Key]
        public int OrderRepitionId { get; set; }
        public int OrderRepitionNo { get; set; }
        public float OrderRepitionTimeLimitHrs { get; set; }
    }
}
