using Day04.PartTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal class PrivateJet : Vehicle
    {
        private int rent;
        private int orderPerHours;
        private int driver;
        public PrivateJet(string noPolice, string vehicleType, int year, long price, int tax, int seat, DateTime transactionDate, int total, int rent, int orderPerHours, int driver) : 
            base(noPolice, vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.rent = rent;
            this.orderPerHours = orderPerHours; 
            this.driver = driver;

            Total = rent + driver;
        }

        public int Rent { get => rent; set => rent = value; }
        public int OrderPerHours { get => orderPerHours; set => orderPerHours = value; }
        public int Driver { get => driver; set => driver = value; }
        public override string ToString()
        {
            return $"no police: {this.NoPolice}, vehicle type: {this.VehicleType}, year: {this.Year}, price: {this.Price}, tax: {this.Tax}, seat: {this.Seat}, transaction date: {this.TransactionDate}, rent: {rent}, order/hour: {orderPerHours}, driver: {driver}, total: {this.Total}";
        }
    }
}
