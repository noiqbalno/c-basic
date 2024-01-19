using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> FindAllEmployees();
        Task<IEnumerable<Employee>> FindAllEmployeesAsync();
        IAsyncEnumerable<Employee> FindAllEmployeesIAsync();
        Employee FindEmployeeById(long id);
        IEnumerable<Employee> FindEmployeeByFirstName(string firstName);
        Employee CreateEmployee(ref Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(long id);

    }
}
