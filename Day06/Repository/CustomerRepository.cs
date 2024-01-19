using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class CustomerRepository : RepositoryDB<Customer>, ICustomerRepository
    {
        public CustomerRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public IEnumerable<Customer> FindAllCustomers()
        {
            IEnumerator<Customer> dataSet = FindAll<Customer>("SELECT CustomerID, CompanyName, ContactName, Country from Customers");

            while (dataSet.MoveNext())
            {
                var customer = dataSet.Current;
                yield return customer;
            }
        }
    }
}
