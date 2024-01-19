using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal class EmployeeImpl : IEmployee
    {
        public void DisplayEmployee(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public List<Employee> GetEmployeeById(List<Employee> employees, int id)
        {
            return employees.FindAll(v => v.EmpId == id);
        }

        public double GetTotalSalary(List<Employee> employees)
        {
            var total = 0.0;
            foreach (Employee emp in employees)
            {
                total += emp.TotalSalary;
            }

            return total;
        }

        public List<Employee> InitListEmployee()
        {
            var listEmployee = new List<Employee>();

            Employee empl = new Employee();

            empl.FullName = "Sentul";
            empl.EmpId = 1;
            empl.JoinDate = DateTime.Now;
            empl.BasicSalary = 5_500;

            //2 implemenet consturctor params
            Employee empl2 = new Employee(2, "Kang Dian", DateTime.Now, 10_000, 0);

            // create object programmer
            Programmer programmer1 = new Programmer(3, "Yuli", DateTime.Now, 6_000, 0, 500);

            // create object sales
            Sales sales1 = new Sales(4, "Widi", DateTime.Now, 7_000, 0, 100, 100);

            listEmployee.Add(empl);
            listEmployee.Add(empl2);
            listEmployee.Add(sales1);
            listEmployee.Add(programmer1);

            return listEmployee;
        }
    }
}
