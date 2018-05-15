using System.Collections.Generic;

namespace CurrencyCloud.Entity.Pagination
{
    public class PaginatedTransfers
    {
        internal PaginatedTransfers() { }

        public List<Transfer> Transfers { get; set; }

        public Pagination Pagination { get; set; }
    }
}