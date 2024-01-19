using Day04.PartOne;
using Day04.PartThree;
using Day04.Quis;
//using Day04.PartTwo;

namespace Day04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Employee empl= new Employee();

             empl.FullName = "Sentul";
             empl.EmpId = 1;
             empl.JoinDate = DateTime.Now;
             empl.BasicSalary = 5_500;

             //2 implemenet consturctor params
             Employee empl2 = new Employee(2, "Kang Dian", DateTime.Now, 10_000, 0);

             var listEmployee = new List<Employee>();
             listEmployee.Add(empl);
             listEmployee.Add(empl2);

             // create object programmer
             Programmer programmer1 = new Programmer(3, "Yuli", DateTime.Now, 6_000, 0, 500);

             // create object sales
             Sales sales1 = new Sales(4, "Widi", DateTime.Now, 7_000, 0, 100, 100);
             listEmployee.Add(sales1);

             //polimorpism?
             listEmployee.Add(programmer1);

             foreach (var item in listEmployee)
             {
                 Console.WriteLine(item.ToString());
             }
             Console.WriteLine($"Total Employee: {Employee.totalEmployee}");
 */

            // PART TWO

            //PartTwo.Employee empl = new PartTwo.Employee(1, "Kang Dian", "123011");
            //Customer cust = new Customer("PT. Code", "12121", "12321");
            //Owner owner1 = new Owner("Äponk", "1233232", "10");

            // CALL INTERFACE AND IMPLEMENTATION

            //IEmployee employeeInterface = new EmployeeImpl();

            //var listEmpls = employeeInterface.InitListEmployee();

            //employeeInterface.DisplayEmployee(listEmpls);

            //var totalSalary = employeeInterface.GetTotalSalary(listEmpls);
            //Console.WriteLine($"Total Salary {totalSalary}");

            //var getEmpById = employeeInterface.GetEmployeeById(listEmpls, 4);
            //employeeInterface.DisplayEmployee(getEmpById);

            // QUIS
            // var listVehicle = new List<Vehicle>();

            //Suv suv1 = new Suv("D 1001 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            //Suv suv2 = new Suv("D 1002 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            //Suv suv3 = new Suv("D 1003 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            //Taxi taxi1 = new Taxi("D 11 UK", "Taxi", 2002, 175_000_000, 1_750_000, 4, DateTime.Now, 0, 45, 4500);
            //Taxi taxi2 = new Taxi("D 12 UK", "Taxi", 2015, 225_000_000, 2_250_000, 4, DateTime.Now, 0, 75, 4500);
            //Taxi taxi3 = new Taxi("D 13 UK", "Taxi", 2020, 275_000_000, 2_750_000, 4, DateTime.Now, 0, 90, 4500);
            //PrivateJet jet1 = new PrivateJet("ID8089", "PrivateJet", 2015, 150_000_000_000, 1_500_000_000, 12, DateTime.Now, 0, 35_000_000, 25_000_000, 15_000_000);
            //PrivateJet jet2 = new PrivateJet("ID8089", "PrivateJet", 2018, 175_000_000_000, 1_750_000_000, 12, DateTime.Now, 0, 55_000_000, 25_000_000, 25_000_000);

            //listVehicle.Add(suv1);
            //listVehicle.Add(suv2);
            //listVehicle.Add(suv3);
            //listVehicle.Add(taxi1);
            //listVehicle.Add(taxi2);
            //listVehicle.Add(taxi3);
            //listVehicle.Add(jet1);
            //listVehicle.Add(jet2);


            //foreach (var item in listVehicle)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //CALL QUIS INTERFACE
            IVehicle vehicle = new VehicleImpl();
            
            var listVehicle = vehicle.InitListVehicle();
            vehicle.DisplayVehicle(listVehicle);

            Console.WriteLine();
            Console.WriteLine($"Total Vehicle: {vehicle.GetTotalVehicle(listVehicle)}");
            Console.WriteLine($"Total Vehicle SUV: {vehicle.GetTotalVehicle(listVehicle, "SUV")}");
            Console.WriteLine($"Total Vehicle Taxi: {vehicle.GetTotalVehicle(listVehicle, "Taxi")}");
            Console.WriteLine($"Total Vehicle PrivateJet: {vehicle.GetTotalVehicle(listVehicle, "PrivateJet")}");
            Console.WriteLine();
            Console.WriteLine($"Sub Total SUV: {vehicle.GetSubTotal(listVehicle, "SUV")}");
            Console.WriteLine($"Sub Total Taxi: {vehicle.GetSubTotal(listVehicle, "Taxi")}");
            Console.WriteLine($"Sub Total PrivateJet: {vehicle.GetSubTotal(listVehicle, "PrivateJet")}");
            Console.WriteLine($"Sub Total: {vehicle.GetSubTotal(listVehicle)}");
        }
    }
}