using Day05.Quis;

namespace Day05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IRepository<Employee> EmpRepo = new EmployeeRepository();
            var listEmployee = InitEmployee();

            //EmpRepo.FindAll(listEmployee);
            //EmpRepo.FindById(listEmployee, 4);
            //EmpRepo.Delete(listEmployee, 4);
            //EmpRepo.FindAll(listEmployee);


            Employee employeeUpdate = new Employee
            {
                EmployeeID = 4,
                FirstName = "Jane",
                LastName = "Smith",
                Title = "Marketing Specialist",
                TitleOfCourtesy = "Ms.",
                BirthDate = new DateTime(1985, 8, 22),
                HireDate = new DateTime(2019, 6, 5),
                HomePhone = "987-654-3210",
                Extension = 5678,
                Photo = "jane_smith_photo.jpg",
                Notes = "Creative and detail-oriented marketer.",
                ReportsTo = 1,
                PhotoPath = "/photos/",
                Address = "456 Oak Avenue",
                City = "Sometown",
                Region = "West",
                PostalCode = "54321",
                Country = "USA"
            };

            //update
            //Console.WriteLine("old");
            //EmpRepo.FindById(listEmployee, 4);
            //Console.WriteLine("new");
            //EmpRepo.Update(listEmployee, employeeUpdate, 4);
            //Console.WriteLine("getall");
            //EmpRepo.FindAll(listEmployee);

            //================
            //supplier

            IRepository<Supplier> SuppRepo = new SupplierRepository();
            var listSupplier = InitSupplier();

            //SuppRepo.FindAll(listSupplier);

            //=========================
            //customer


            IRepository<Customer> CustRepo = new CustomerRepository();
            var listCustomer = InitCustomer();

            CustRepo.FindAll(listCustomer);
            //CustRepo.Delete(listCustomer, 3);
        }

        private static List<Employee> InitEmployee()
        {
            IRepository<Employee> EmpRepo = new EmployeeRepository();
            List<Employee> listEmployee = new();

            Employee emp1 = new()
            {
                EmployeeID = 1,
                FirstName = "John",
                LastName = "Doe",
                Title = "Software Engineer",
                TitleOfCourtesy = "Mr.",
                BirthDate = new DateTime(1990, 5, 15),
                HireDate = new DateTime(2020, 3, 10),
                HomePhone = "123-456-7890",
                Extension = 1234,
                Photo = "john_doe_photo.jpg",
                Notes = "Hardworking employee with a positive attitude.",
                ReportsTo = null,
                PhotoPath = "/photos/",
                Address = "123 Main Street",
                City = "Anytown",
                Region = "East",
                PostalCode = "12345",
                Country = "USA"
            };

            Employee employee1 = new Employee
            {
                EmployeeID = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Title = "Marketing Specialist",
                TitleOfCourtesy = "Ms.",
                BirthDate = new DateTime(1985, 8, 22),
                HireDate = new DateTime(2019, 6, 5),
                HomePhone = "987-654-3210",
                Extension = 5678,
                Photo = "jane_smith_photo.jpg",
                Notes = "Creative and detail-oriented marketer.",
                ReportsTo = 1,
                PhotoPath = "/photos/",
                Address = "456 Oak Avenue",
                City = "Sometown",
                Region = "West",
                PostalCode = "54321",
                Country = "USA"
            };

            Employee employee2 = new Employee
            {
                EmployeeID = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mr.",
                BirthDate = new DateTime(1992, 4, 18),
                HireDate = new DateTime(2021, 2, 15),
                HomePhone = "555-123-4567",
                Extension = 9876,
                Photo = "michael_johnson_photo.jpg",
                Notes = "Energetic and goal-driven sales professional.",
                ReportsTo = 1,
                PhotoPath = "/photos/",
                Address = "789 Pine Street",
                City = "Cityville",
                Region = "South",
                PostalCode = "67890",
                Country = "USA"
            };

            Employee employee3 = new Employee
            {
                EmployeeID = 4,
                FirstName = "Emily",
                LastName = "Davis",
                Title = "Human Resources Manager",
                TitleOfCourtesy = "Ms.",
                BirthDate = new DateTime(1980, 12, 5),
                HireDate = new DateTime(2018, 9, 20),
                HomePhone = "777-999-8888",
                Extension = 4321,
                Photo = "emily_davis_photo.jpg",
                Notes = "Experienced HR professional with a focus on employee well-being.",
                ReportsTo = null,
                PhotoPath = "/photos/",
                Address = "101 Maple Lane",
                City = "Villagetown",
                Region = "North",
                PostalCode = "12345",
                Country = "USA"
            };

            Employee employee4 = new Employee
            {
                EmployeeID = 5,
                FirstName = "David",
                LastName = "Brown",
                Title = "Software Developer",
                TitleOfCourtesy = "Mr.",
                BirthDate = new DateTime(1991, 7, 12),
                HireDate = new DateTime(2022, 1, 8),
                HomePhone = "333-555-7777",
                Extension = 8765,
                Photo = "david_brown_photo.jpg",
                Notes = "Passionate about coding and problem-solving.",
                ReportsTo = 1,
                PhotoPath = "/photos/",
                Address = "789 Elm Street",
                City = "Techville",
                Region = "East",
                PostalCode = "56789",
                Country = "USA"
            };

            EmpRepo.Save(listEmployee, emp1);
            EmpRepo.Save(listEmployee, employee1);
            EmpRepo.Save(listEmployee, employee2);
            EmpRepo.Save(listEmployee, employee3);
            EmpRepo.Save(listEmployee, employee4);

            return listEmployee;
        }

        private static List<Supplier> InitSupplier()
        {
            IRepository<Supplier> SuppRepo = new SupplierRepository();
            List<Supplier> listSupplier = new();

            Supplier supplier = new Supplier
            {
                SupplierID = 1,
                CompanyName = "ABC Corporation",
                ContactName = "John Smith",
                ContactTitle = "Purchasing Manager",
                HomePage = "http://www.abccorp.com",
                Address = "123 Main Street",
                City = "Anytown",
                Region = "East",
                PostalCode = "12345",
                Country = "USA"
            };
            Supplier supplier1 = new Supplier
            {
                SupplierID = 2,
                CompanyName = "XYZ Ltd.",
                ContactName = "Alice Johnson",
                ContactTitle = "Sales Manager",
                HomePage = "http://www.xyzltd.com",
                Address = "456 Oak Avenue",
                City = "Sometown",
                Region = "West",
                PostalCode = "54321",
                Country = "USA"
            };

            Supplier supplier2 = new Supplier
            {
                SupplierID = 3,
                CompanyName = "123 Electronics",
                ContactName = "Bob Anderson",
                ContactTitle = "Technical Director",
                HomePage = "http://www.123electronics.com",
                Address = "789 Pine Street",
                City = "Cityville",
                Region = "South",
                PostalCode = "67890",
                Country = "USA"
            };

            Supplier supplier3 = new Supplier
            {
                SupplierID = 4,
                CompanyName = "Global Foods",
                ContactName = "Emily Davis",
                ContactTitle = "Supply Chain Manager",
                HomePage = "http://www.globalfoods.com",
                Address = "101 Maple Lane",
                City = "Villagetown",
                Region = "North",
                PostalCode = "12345",
                Country = "USA"
            };

            Supplier supplier4 = new Supplier
            {
                SupplierID = 5,
                CompanyName = "Tech Solutions Inc.",
                ContactName = "David Brown",
                ContactTitle = "IT Manager",
                HomePage = "http://www.techsolutions.com",
                Address = "789 Elm Street",
                City = "Techville",
                Region = "East",
                PostalCode = "56789",
                Country = "USA"
            };

            SuppRepo.Save(listSupplier, supplier);
            SuppRepo.Save(listSupplier, supplier1);
            SuppRepo.Save(listSupplier, supplier2);
            SuppRepo.Save(listSupplier, supplier3);
            SuppRepo.Save(listSupplier, supplier4);

            return listSupplier;
        }
        private static List<Customer> InitCustomer()
        {
            IRepository<Customer> CustRepo = new CustomerRepository();
            List<Customer> listCustomer = new();

            Customer customer1 = new Customer
            {
                CustomerID = 1,
                CompanyName = "ABC Corporation",
                ContactName = "John Smith",
                ContactTitle = "CEO",
                Address = "123 Main Street",
                City = "Anytown",
                Region = "East",
                PostalCode = "12345",
                Country = "USA"
            };

            Customer customer2 = new Customer
            {
                CustomerID = 2,
                CompanyName = "XYZ Ltd.",
                ContactName = "Alice Johnson",
                ContactTitle = "Sales Manager",
                Address = "456 Oak Avenue",
                City = "Sometown",
                Region = "West",
                PostalCode = "54321",
                Country = "USA"
            };

            Customer customer3 = new Customer
            {
                CustomerID = 3,
                CompanyName = "123 Electronics",
                ContactName = "Bob Anderson",
                ContactTitle = "Marketing Director",
                Address = "789 Pine Street",
                City = "Cityville",
                Region = "South",
                PostalCode = "67890",
                Country = "USA"
            };

            Customer customer4 = new Customer
            {
                CustomerID = 4,
                CompanyName = "Global Foods",
                ContactName = "Emily Davis",
                ContactTitle = "Operations Manager",
                Address = "101 Maple Lane",
                City = "Villagetown",
                Region = "North",
                PostalCode = "54321",
                Country = "USA"
            };

            Customer customer5 = new Customer
            {
                CustomerID = 5,
                CompanyName = "Tech Solutions Inc.",
                ContactName = "David Brown",
                ContactTitle = "CTO",
                Address = "789 Elm Street",
                City = "Techville",
                Region = "East",
                PostalCode = "56789",
                Country = "USA"
            };

            CustRepo.Save(listCustomer, customer1);
            CustRepo.Save(listCustomer, customer2);
            CustRepo.Save(listCustomer, customer3);
            CustRepo.Save(listCustomer, customer4);
            CustRepo.Save(listCustomer, customer5);

            return listCustomer;
        }
    }
}