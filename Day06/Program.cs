using Day06.DbContext;
using Day06.Entity;
using Day06.Repository;
using Microsoft.Extensions.Configuration;
using System.Runtime.InteropServices;

internal class Program
{
    private static IConfigurationRoot Configuration;
    //private static void Main(string[] args)
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BuildConfiguration();
        var adoDbContext = new AdoDbContext(Configuration.GetConnectionString("NorthWindDS"));

        ////call interface, implement solid dependency inversion
        //IRepository repositoryDb = new RepositoryDB(adoDbContext);

        ////call method di interface
        //var employees = repositoryDb.FindAll();

        //while(employees.MoveNext())
        //{
        //    var employee = employees.Current;
        //    Console.WriteLine(employee.ToString());
        //}

        //Console.WriteLine("with enumerable");

        //var emps = repositoryDb.FindAllEmployee();
        //foreach (var item in emps)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //=============##########
        //generic

        //employee
        //IEmployeeRepository employeeRepository = new EmployeeRepository(adoDbContext);
        //var emps = employeeRepository.FindAllEmployees();
        //foreach (var item in emps)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //get employees with async
        //var employeeAsync = employeeRepository.FindAllEmployeesAsync();
        //foreach (var item in await employeeAsync)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //empoyee by id
        //var foundEmployee = employeeRepository.FindEmployeeById(8);
        //Console.WriteLine($"Found Empployee : {foundEmployee}");

        //4. FindEmployeeByFirstName
        //var filterEmployeeByName = employeeRepository.FindEmployeeByFirstName("A%");
        //foreach (var employee in filterEmployeeByName)
        //{
        //    Console.WriteLine(employee.ToString());
        //}

        //5. createEmployee, EmployeeId ga diisi, otomatis dari sequence database
        //var newEmps = new Employee
        //{
        //    FirstName = "Yuli",
        //    LastName = "Ayu",
        //    BirthDate = DateTime.Now
        //};

        //newEmps = employeeRepository.CreateEmployee(ref newEmps);
        //Console.WriteLine(newEmps.ToString());

        //6. Update Employee
        //var findUpdateEmps = new Employee
        //{
        //    EmployeeId = 10,
        //    FirstName = "Widi",
        //    LastName = "Wini",
        //    BirthDate = DateTime.Now
        //};

        //var updateEmp = employeeRepository.UpdateEmployee(findUpdateEmps);
        //Console.WriteLine(updateEmp.ToString());


        //7. delete employee by id 10
        //employeeRepository.DeleteEmployee(10);

        // employee generic
        IRepositoryBase<Employee> repositoryEmployeeGeneric = new EmployeeRepositoryGeneric(adoDbContext);
        var emps = repositoryEmployeeGeneric.FindAll();
        //emps.foreach
        foreach (var item in emps)
        {
            Console.WriteLine(item.ToString());
        }

        //ends employee

        //supllier
        //ISupplierRepository supplierRepository = new SupplierRepository(adoDbContext);
        //var supps = supplierRepository.FindAllSuppliers();
        //foreach (var item in supps)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //ends supplier

        //customer

        //ICustomerRepository customerRepository = new CustomerRepository(adoDbContext);
        //var custs = customerRepository.FindAllCustomers();
        //foreach (var item in custs)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //IRepositoryBase<Customer> customerRepoG = new CustomerRepositoryGeneric(adoDbContext);
        //var custs = customerRepoG.FindAll();

        //foreach (var item in custs)
        //{
        //    Console.WriteLine(item.ToString());
        //}

    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));
    }
}