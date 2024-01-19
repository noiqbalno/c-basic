using Day06.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal abstract class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        protected readonly AdoDbContext _adoDbContext;
        protected RepositoryBase(AdoDbContext adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        //public virtual IEnumerator<T> FindAll<T>(SqlCommandModel query)
        //{
        //    var dataSet = _adoDbContext.ExecuteReader<T>(query);
        //    _adoDbContext.Dispose();

        //    return dataSet;
        //}

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindById()
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
