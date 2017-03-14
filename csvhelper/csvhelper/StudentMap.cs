using System.Globalization;
using CsvHelper.Configuration;

namespace csvhelper
{
    public sealed class StudentMap: CsvClassMap<Student>
    {
        public StudentMap()
        {
            Map(m => m.Id);
            Map(m => m.Name);
            Map(m => m.Currency).Name("currency").TypeConverterOption(NumberStyles.Currency);
            References<AddressMap>(m => m.Address);
        }
    }
}
