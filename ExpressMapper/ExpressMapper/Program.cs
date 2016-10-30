using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("object mapping:" + evm.Id + "," + evm.Name);

            //collection mapping
            var employee2 = new Employee() {Id = 2, Name = "Dido"};
            var listOfEmployees = new List<Employee> {employee, employee2};
            var evms = listOfEmployees.Map<List<Employee>, List<EmployeeViewModel>>();
            evms.ForEach(x => Console.WriteLine("Collection Mapping :" + x.Id + "," + x.Name));

            //object with different properties
            Mapper.Register<Employee, HrEmployeeViewModel>().Member(dest => dest.HrEmployeeName, src => src.Name);
            var hrevm = employee.Map<Employee, HrEmployeeViewModel>();
            Console.WriteLine("object with different properties :" + hrevm.Id + "," + hrevm.HrEmployeeName);

            //function mapping 
            Mapper.Register<Employee, RetailViewModel>().Function(dest => dest.Salary, src => src.Name == "Fido" ? 10000 : 1000);
            var revm2 = employee.Map<Employee, RetailViewModel>();
            var revm3 = employee2.Map<Employee, RetailViewModel>();
            Console.WriteLine("function mapping -->" + "Fido's Salary : " + revm2.Salary + " Dido's Salary :" + revm3.Salary);

            //ignore properties
            Mapper.Register<Employee, FinanceEmployeeViewModel>().Ignore(dest => dest.Name);
            var fevm = employee.Map<Employee, FinanceEmployeeViewModel>();
            Console.WriteLine("Ignore -->" + "Id :" + fevm.Id + " Name should be ignored :" + fevm.Name);

            //custom mapper
            Mapper.RegisterCustom<Employee, CommunicationsViewModel, CustomMapper>();
            var cevm = employee.Map<Employee, CommunicationsViewModel>();
            Console.WriteLine("custom mapping -->" + "Id :" + cevm.Id + " Name :" + cevm.Name);

            Console.ReadLine();
        }
    }
} 