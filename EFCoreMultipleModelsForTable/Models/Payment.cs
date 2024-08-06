namespace EFCoreMultipleModelsForTable.Models
{
    public abstract class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }

}
