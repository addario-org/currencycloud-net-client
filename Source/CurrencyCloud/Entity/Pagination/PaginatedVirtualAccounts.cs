using System.Collections.Generic;

namespace CurrencyCloud.Entity.Pagination
{
    public class PaginatedVirtualAccounts
    {
        internal PaginatedVirtualAccounts() { }

        public List<VirtualAccount> VirtualAccounts { get; set; }

        public Pagination Pagination { get; set; }
    }
}