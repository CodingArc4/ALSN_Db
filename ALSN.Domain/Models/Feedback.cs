using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALSN.Domain.Models
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
