using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Employee : Person
    {
        private int empId;
        private DateTime joinDate;
        private double basicSalary;
        private double totalSalary;


        //static attr
        public static int totalEmployee = 0;

        public Employee(int empId, string fullName, string npwp) : base(fullName, npwp)
        {
            this.empId = empId;
        }

        // def connsturcotr
        //public Employee()
        //{
        //    totalEmployee++;
        //}

        //public override string? ToString()
        //{
        //    return $"EmpId: {empId}, fullname: ${fullName}, joinDate: ${joinDate}, basicSalary: ${basicSalary}, totalSalary: ${totalSalary}";
        //}
    }
}
