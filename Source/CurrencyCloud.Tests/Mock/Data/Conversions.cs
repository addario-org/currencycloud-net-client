namespace CurrencyCloud.Tests.Mock.Data
{
    static class Conversions
    {
        public static readonly Entity.ConversionCreate Conversion1 = new Entity.ConversionCreate(
            "EUR",
            "GBP",
            "buy",
            10000.23m,
            true,
            "my-unique-id"
        );
    }
}