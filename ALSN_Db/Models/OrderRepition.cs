using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class OrderRepition
    {
        [Key]
        public int OrderRepitionID { get; set; }
        public int OrderRepitionNo { get; set; }
        public float OrderRepitionTimeLimitHrs { get; set; }
    }
}
