using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Quis
{
    internal abstract class AbstractPerson
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    internal abstract class AbstractPersonContact : AbstractPerson
    {
        public string CompanyName {  get; set; }
        public string ContactName { get; set; }
        public string ContactTitle {  get; set; }
        public string phone{ get; set; }
        public string fax{ get; set; }

    }
}
