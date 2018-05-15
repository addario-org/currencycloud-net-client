using System.Collections.Generic;

namespace CurrencyCloud.Entity.Pagination
{
    public class PaginatedIbans
    {
        internal PaginatedIbans() { }

        public List<Iban> Ibans { get; set; }

        public Pagination Pagination { get; set; }
    }
}