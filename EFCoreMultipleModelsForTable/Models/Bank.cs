namespace EFCoreMultipleModelsForTable.Models
{
    public class Bank
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
