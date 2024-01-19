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
    internal class EmployeeRepositoryGeneric : RepositoryBase<Employee>
    {
        public EmployeeRepositoryGeneric(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public override IEnumerable<Employee> FindAll()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };

            var dataSet = _adoDbContext.ExecuteReader<Employee>(model);

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
