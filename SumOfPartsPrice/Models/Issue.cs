using SumOfPartsPrice.Data;

namespace SumOfPartsPrice.Models
{
    public class Issue
    {
        public int IssueId { get; set; }
        public string Problem { get; set; }
        public string PartsNeed { get; set; }
        public decimal PartsPrice { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }

 

    }


}
