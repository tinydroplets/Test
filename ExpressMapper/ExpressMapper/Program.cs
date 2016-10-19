using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ExpressMapper.Extensions;

namespace ExpressMapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            //simple mapping to EmployeeViewModel
            Mapper.Register<Employee, EmployeeViewModel>();
            var employee = new Employee() {Id = 1, Name = "Fido"};
            var evm = employee.Map<Employee, EmployeeViewModel>();
        }
    }
}
