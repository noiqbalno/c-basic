using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class EmployeeTest
    {
        public long EmpId { get; set; }
        public string? FullName { get; set; }

        public override string? ToString()
        {
            return $"Empid : {EmpId}, FullName : {FullName}";
        }
    }
}
