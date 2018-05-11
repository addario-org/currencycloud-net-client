namespace CurrencyCloud.Tests.Mock.Data
{
    static class Accounts
    {
        public static readonly Entity.Account Account1 = new Entity.Account(
            "Acme Ltd.",
            "company",
            "164 Bishops Gate",
            "London",
            "CR4 3RZ",
            "GB")
            { 
                YourReference = "POS-UID-23523",
                Status = "enabled",
                StateOrProvince = "Ontario",
                SpreadTable = "no_markup",
                IdentificationType = "none"
        };

        public static readonly Entity.Account Account2 = new Entity.Account( 
            "Company PLC",
            "company",
            "13 London Road",
            "London",
            "AB12 CD2",
            "GB")
        { 
            YourReference = "0012345564ABC",
            Status = "enabled",
            StateOrProvince = "",
            SpreadTable = "flat_0.5_percent",
            IdentificationType = "none"
        };
    }
}