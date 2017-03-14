using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace csvhelper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string fileName = @"C:\Users\amamuwala\Desktop\Documents\Project Testing\csvhelper-files\employee.csv";
            var csv = new CsvReader( File.OpenText(fileName) );

            //read records
            csv.Configuration.RegisterClassMap<StudentMap>();
            var records = csv.GetRecords<Student>().ToList();
            //var listOfRecords = records.ToList();
            csv.Dispose();

            //write records
            var employeeList = new List<Employee>() { new Employee() { Id = 3, Name = "Cotton Candy"}};
            //listOfRecords.AddRange(employeeList);
            using (var textWriter = new StreamWriter(fileName))
            {
                var csvWriter = new CsvWriter(textWriter);
                csvWriter.WriteRecords(records);
                textWriter.Close();
            }
        }
    }
}
