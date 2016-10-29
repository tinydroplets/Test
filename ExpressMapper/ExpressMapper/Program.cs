using System;
using System.Collections.Generic;
using ExpressMapper.Extensions;

namespace ExpressMapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            //object mapping to EmployeeViewModel
            Mapper.Register<Employee, EmployeeViewModel>();
            var employee = new Employee() {Id = 1, Name = "Fido"};
            var evm = employee.Map<Employee, EmployeeViewModel>();
            Console.WriteLine("object mapping:"+ evm.Id + "," + evm.Name);

            //collection mapping
            var employee2 = new Employee() {Id = 2, Name = "Dido"};
            var listOfEmployees = new List<Employee> {employee, employee2};
            var evms = listOfEmployees.Map<List<Employee>, List<EmployeeViewModel>>();
            evms.ForEach(x => Console.WriteLine( "Collection Mapping :"+ x.Id + "," + x.Name)); 
    
            //object with different properties
            Mapper.Register<Employee, HrEmployeeViewModel>().Member(dest => dest.HrEmployeeName, src => src.Name);
            var hrevm = employee.Map<Employee, HrEmployeeViewModel>();
            Console.WriteLine("object with different properties :" + hrevm.Id + "," + hrevm.HrEmployeeName);

            Console.ReadLine();
        }
    }
} 