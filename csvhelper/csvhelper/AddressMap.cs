using CsvHelper.Configuration;

namespace csvhelper
{
    public sealed class AddressMap : CsvClassMap<Address>
    {
        public AddressMap()
        {
            Map(m => m.StreetName).Name("streetname");
            Map(m => m.State).Name("state");
            Map(m => m.City).Name("city");
        }
    }
}
