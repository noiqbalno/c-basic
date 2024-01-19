using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal abstract class RepositoryDB<T> : IRepository<T> where T : class
    {
        private readonly AdoDbContext _adoDbContext;
        public RepositoryDB(AdoDbContext adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        //public IEnumerator<Employee> FindAll()
        //{
        //    IEnumerator<Employee> dataSet = _adoDbContext
        //        .ExecuteReader<Employee>("SELECT EmployeeId, LastName, FirstName, BirthDate from Employees");

        //    _adoDbContext.Dispose();

        //    return dataSet;
        //}

        //public IEnumerable<Employee> FindAllEmployee()
        //{
        //    IEnumerator<Employee> dataSet = _adoDbContext
        //        .ExecuteReader<Employee>("SELECT EmployeeId, LastName, FirstName, BirthDate from Employees");

        //    _adoDbContext.Dispose();

        //    while(dataSet.MoveNext())
        //    {
        //        var employee = dataSet.Current;
        //        yield return employee;
        //    }

        //}

        public IEnumerator<T> FindAll<T>(string query)
        {
            var dataSet = _adoDbContext.ExecuteReader<T>(query);
            _adoDbContext.Dispose();

            return dataSet;
        }
        public IEnumerator<T> FindById<T>(SqlCommandModel query)
        {
            var dataSet = _adoDbContext.ExecuteReader<T>(query);
            _adoDbContext.Dispose();

            return dataSet;
        }
        public IEnumerator<T> FindByAttr<T>(SqlCommandModel query)
        {
            var dataSet = _adoDbContext.ExecuteReader<T>(query);
            _adoDbContext.Dispose();

            return dataSet;
        }

        public void Create<T>(SqlCommandModel query)
        {
            _adoDbContext.ExecuteNonQuery(query);
            _adoDbContext.Dispose();
        }

        public void Update<T>(SqlCommandModel query)
        {
            _adoDbContext.ExecuteNonQuery(query);
            _adoDbContext.Dispose();
        }

        public void Delete<T>(SqlCommandModel query)
        {
            _adoDbContext.ExecuteNonQuery(query);
            _adoDbContext.Dispose();
        }
    }
}
