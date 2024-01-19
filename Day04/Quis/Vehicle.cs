using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal class Vehicle : AbstractVehicle
    {
        private DateTime transactionDate;
        private int total;


        public Vehicle(string noPolice, string vehicleType, int year, long price, int tax, int seat, DateTime transactionDate, int total)
            : base(noPolice, vehicleType, year, price, tax, seat)
        {
            this.transactionDate = transactionDate;
            this.total = total;
        }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public int Total { get => total; set => total = value; }

        public override string ToString()
        {
            return $"no police: {this.NoPolice}, vehicle type: {this.VehicleType}, year: {this.Year}, price: {this.Price}, tax: {this.Tax}, seat: {this.Seat}, transaction date: {transactionDate}";
        }
    }
}
