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
            Console.WriteLine("object mapping:"+ evm.Id + "," + evm.Name);

            //collection mapping
            var employee2 = new Employee() {Id = 2, Name = "Dido"};
            var listOfEmployees = new List<Employee> {employee, employee2};
            var evms = listOfEmployees.Map<List<Employee>, List<EmployeeViewModel>>();
            evms.ForEach(x => Console.WriteLine( "Collection Mapping :"+ x.Id + "," + x.Name)); 


            //object with different property mapping and function mapping
            Mapper.Register<Employee, HrEmployeeViewModel>().Member(dest => dest.HrEmployeeName, src => src.Name)
                                                            .Function(dest => dest.Salary, src => src.Name == "Fido" ? 10000 : 1000);
            
            //object with different properties
            var hrevm = employee.Map<Employee, HrEmployeeViewModel>();
            Console.WriteLine("object with different properties :" + hrevm.Id + "," + hrevm.HrEmployeeName);

            //function mapping 
            var hrevm2 = employee.Map<Employee, HrEmployeeViewModel>();
            var hrevm3 = employee2.Map<Employee, HrEmployeeViewModel>();
            Console.WriteLine("function mapping -->" + "Fido's Salary : " + hrevm2.Salary + " Dido's Salary :" + hrevm3.Salary);

            //ignore properties
            Mapper.Register<Employee, FinanceEmployeeViewModel>().Ignore(dest => dest.Name);
            var hrevm4 = employee.Map<Employee, FinanceEmployeeViewModel>();
            Console.WriteLine("Ignore -->" + "Id :"+ hrevm4.Id + " Name should be ignored :" + hrevm4.Name);
            Console.ReadLine();
        }
    }
} 