using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Entity
{
    internal class Employee
    {
        public long EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        //public string? Title { get; set; }
        //public string? TitleOfCourtesy { get; set; }
        //public DateTime BirthDate { get; set; }
        //public DateTime HireDate { get; set; }
        public DateTime BirthDate;
        //public DateTime HireDate;

        public override string? ToString()
        {
            return $"Empid : {EmployeeId}, LastName : {LastName}, Firstname: { FirstName}, BirthDate: {BirthDate} ";
        }
    }

}
