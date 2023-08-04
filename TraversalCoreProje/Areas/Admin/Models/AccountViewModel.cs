namespace TraversalCoreProje.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public decimal Amount { get; set; }
        public decimal SenderNewBalance { get; set; }
        public decimal ReceiverNewBalance { get; set; }
    }
}
