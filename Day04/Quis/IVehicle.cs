using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal interface IVehicle
    {
        List<Vehicle> InitListVehicle();

        public void DisplayVehicle(List<Vehicle> vehicles);

        int GetSubTotal(List<Vehicle> vehicles);
        int GetSubTotal(List<Vehicle> vehicles, string type);

        int GetTotalVehicle(List<Vehicle> vehicles);
        int GetTotalVehicle(List<Vehicle> vehicles, string type);
    }
}
