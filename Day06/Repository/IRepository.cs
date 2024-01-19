using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal interface IRepository<T>
    {
        //IEnumerable<Employee> FindAllEmployee();
        IEnumerator<T> FindAll<T>(string query);
        IEnumerator<T> FindById<T>(SqlCommandModel query);
        IEnumerator<T> FindByAttr<T>(SqlCommandModel query);
        void Create<T>(SqlCommandModel query);
        void Update<T>(SqlCommandModel query);
        void Delete<T>(SqlCommandModel query);


    }
}
