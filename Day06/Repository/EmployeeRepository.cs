using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Activity;

namespace Day06.Repository
{
    internal class EmployeeRepository : RepositoryDB<Employee>, IEmployeeRepository
    {
        private readonly AdoDbContext _adoDbContext;

        public EmployeeRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        public IEnumerable<Employee> FindAllEmployees()
        {
            IEnumerator <Employee> dataSet = FindAll<Employee>("SELECT EmployeeId, LastName, FirstName, BirthDate from Employees");

            while (dataSet.MoveNext())
            {
                var employee = dataSet.Current;
                yield return employee;
            }
        }

        public Employee FindEmployeeById(long id)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees where EmployeeId=@empId;",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = id
                    }
                }
            };

            var dataSet = FindById<Employee>(model);

            var employee = new Employee();

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (dataSet.MoveNext())
            {
                employee = dataSet.Current;
            }


            return employee;
        }

        public IEnumerable<Employee> FindEmployeeByFirstName(string firstName)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees where FirstName like @firstName",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = firstName
                    }
                }
            };

            var dataSet = FindByAttr<Employee>(model);

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (dataSet.MoveNext())
            {
                var employee = dataSet.Current;
                yield return employee;
            }
        }
        public Employee CreateEmployee(ref Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "insert into employees (LastName,FirstName,BirthDate) values (@lastName,@firstName,@birthDate);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int32,
                        Value = employee.EmployeeId
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@lastName",
                        DataType = DbType.String,
                        Value = employee.LastName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@birthDate",
                        DataType = DbType.DateTime,
                        Value = employee.BirthDate
                    }
                }
            };

            Create<Employee>(model);

            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "UPDATE employees SET FirstName=@firstName, LastName=@lastName, BirthDate=@birthDate WHERE employeeId=@empId",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@lastName",
                        DataType = DbType.String,
                        Value = employee.LastName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@firstName",
                        DataType = DbType.String,
                        Value = employee.FirstName
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@birthDate",
                        DataType = DbType.DateTime,
                        Value = employee.BirthDate
                    },
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value = employee.EmployeeId
                    }
                }
            };

            Update<Employee>(model);

            return employee;
        }

        public void DeleteEmployee(long id)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "DELETE FROM employees WHERE employeeId=@empId",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {
                    new SqlCommandParameterModel() {
                        ParameterName = "@empId",
                        DataType = DbType.Int64,
                        Value =id
                    }
                }
            };

            Delete<Employee>(model);
        }

        public async Task<IEnumerable<Employee>> FindAllEmployeesAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {}
            };

            var dataSet = _adoDbContext.ExecuteReaderAsync<Employee>(model);

            var employees = new List<Employee>();

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (await dataSet.MoveNextAsync())
            {
                employees.Add(dataSet.Current);
                //yield return employee;
            }

            _adoDbContext.Dispose();
            return employees;
        }

        public async IAsyncEnumerable<Employee> FindAllEmployeesIAsync()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] { }
            };

            var dataSet = _adoDbContext.ExecuteReaderAsync<Employee>(model);

            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (await dataSet.MoveNextAsync())
            {
                var employee = dataSet.Current;
                yield return employee;
            }

            _adoDbContext.Dispose();
        }
    }
}
