using System.Collections.Generic;

namespace CurrencyCloud.Entity.List
{
    public class PayerDetailsList
    {
        internal PayerDetailsList() { }

        public List<Dictionary<string, string>> Details { get; set; }
    }
}
