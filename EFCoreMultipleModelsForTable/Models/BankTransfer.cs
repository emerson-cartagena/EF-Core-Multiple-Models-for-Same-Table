using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMultipleModelsForTable.Models
{
    public class BankTransfer : Payment
    {
        public string AccountNumber { get; set; }
    }
}
