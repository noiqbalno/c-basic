using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class SupplierRepository : RepositoryDB<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public IEnumerable<Supplier> FindAllSuppliers()
        {
            IEnumerator<Supplier> dataSet = FindAll<Supplier>("SELECT SupplierID, CompanyName, ContactName, HomePage from Suppliers");

            while (dataSet.MoveNext())
            {
                var supplier = dataSet.Current;
                yield return supplier;
            }
        }
    }
}
