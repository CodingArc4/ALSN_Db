using System.ComponentModel.DataAnnotations;

namespace ALSN_Db.Models
{
    public class Chat
    {
        [Key]
        public long ChatID { get; set; }
        public long OrderID { get; set; }
        public long SenderID { get; set; }
        public long ReceiverID { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }

        public Order Order { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
