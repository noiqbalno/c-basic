using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal class VehicleImpl : IVehicle
    {
        public void DisplayVehicle(List<Vehicle> vehicles)
        {
            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public int GetSubTotal(List<Vehicle> vehicles)
        {
            var subtotal = 0;
            foreach (Vehicle item in vehicles)
            {
                subtotal += item.Total;
            }

            return subtotal;
        }

        public int GetSubTotal(List<Vehicle> vehicles, string type)
        {
            var subtotal = 0;
            var vehByType = vehicles.FindAll(v => v.VehicleType == type);
            foreach (Vehicle item in vehByType)
            {
                subtotal += item.Total;
            }

            return subtotal;
        }

        public int GetTotalVehicle(List<Vehicle> vehicles)
        {
            //return vehicles.Count();
            var totalV = vehicles.GroupBy(x => x.NoPolice).Select(x => x.First()).ToList();
            return totalV.Count();
        }

        public int GetTotalVehicle(List<Vehicle> vehicles, string type)
        {
            var get = vehicles.FindAll(v => v.VehicleType == type);
            var filtered = get.GroupBy(x => x.NoPolice).Select(x => x.First()).ToList();

            return filtered.Count();
        }

        public List<Vehicle> InitListVehicle()
        {
            var listVehicle = new List<Vehicle>();

            Suv suv1 = new Suv("D 1001 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            Suv suv2 = new Suv("D 1002 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            Suv suv3 = new Suv("D 1003 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            Suv suv4 = new Suv("D 1004 UM", "SUV", 2010, 350_000_000, 3_500_000, 4, DateTime.Now, 0, 500_000, 150_000);
            Taxi taxi1 = new Taxi("D 11 UK", "Taxi", 2002, 175_000_000, 1_750_000, 4, DateTime.Now, 0, 45, 4500);
            Taxi taxi2 = new Taxi("D 12 UK", "Taxi", 2015, 225_000_000, 2_250_000, 4, DateTime.Now, 0, 75, 4500);
            Taxi taxi3 = new Taxi("D 13 UK", "Taxi", 2020, 275_000_000, 2_750_000, 4, DateTime.Now, 0, 90, 4500);
            PrivateJet jet1 = new PrivateJet("ID8089", "PrivateJet", 2015, 150_000_000_000, 1_500_000_000, 12, DateTime.Now, 0, 35_000_000, 25_000_000, 15_000_000);
            PrivateJet jet2 = new PrivateJet("ID8099", "PrivateJet", 2018, 175_000_000_000, 1_750_000_000, 12, DateTime.Now, 0, 55_000_000, 25_000_000, 25_000_000);

            listVehicle.Add(suv1);
            listVehicle.Add(suv2);
            listVehicle.Add(suv3);
            listVehicle.Add(suv4);
            listVehicle.Add(taxi1);
            listVehicle.Add(taxi2);
            listVehicle.Add(taxi3);
            listVehicle.Add(jet1);
            listVehicle.Add(jet2);

            return listVehicle;
        }
    }
}
