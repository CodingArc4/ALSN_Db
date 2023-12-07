using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Feedback
    {
        [Key]
        public long FeedBackID { get; set; }
        public long GuestID { get; set; }
        public DateTime FeedBackDate { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public User Guest { get; set; }
    }
}
