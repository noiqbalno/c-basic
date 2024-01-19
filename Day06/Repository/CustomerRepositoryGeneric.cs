using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class CustomerRepositoryGeneric : RepositoryBase<Customer>, ICustomer
    {
        public CustomerRepositoryGeneric(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public double CalculateIncome(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customer> FindAll()
        {   
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select CustomerID,CompanyName from customers",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };

            var dataSet = _adoDbContext.ExecuteReader<Customer>(model);

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (dataSet.MoveNext())
            {
                var item = dataSet.Current;
                yield return item;
            }


            _adoDbContext.Dispose();
        }
    }
}
