using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreMultipleModelsForTable.Models
{
    public class Check : Payment
    {
        public string CheckNumber { get; set; }
    }
}
