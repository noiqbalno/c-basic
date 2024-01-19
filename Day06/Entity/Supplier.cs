using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Entity
{
    internal class Supplier
    {
        public int SupplierID { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        //public string? ContactTitle { get; set; }
        //public string? Address { get; set; }
        //public string? City { get; set; }
        //public string? Region { get; set; }
        //public string? PostalCode { get; set; }
        //public string? Country { get; set; }
        //public string? Phone { get; set; }
        //public string? Fax { get; set; }
        public string? HomePage { get; set; }
        public override string ToString()
        {
            return $"SupplierID: {SupplierID}\n" +
                   $"CompanyName: {CompanyName}\n" +
                   $"ContactName: {ContactName}\n" +
                   //$"ContactTitle: {ContactTitle}\n" +
                   //$"Address: {Address}\n" +
                   //$"City: {City}\n" +
                   //$"Region: {Region}\n" +
                   //$"Postal Code: {PostalCode}\n" +
                   //$"Country: {Country}\n" +
                   //$"Phone: {Phone}\n" +
                   //$"Fax: {Fax}\n" +
                   $"HomePage: {HomePage}\n";
        }
    }
}
