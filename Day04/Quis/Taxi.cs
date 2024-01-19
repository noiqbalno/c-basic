using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal class Taxi : Vehicle
    {
        private int order;
        private int orderPerKm;
        public Taxi(string noPolice, string vehicleType, int year, int price, int tax, int seat, DateTime transactionDate, int total, int order, int orderPerkm) : 
            base(noPolice, vehicleType, year, price, tax, seat, transactionDate, total)
        {
            this.order = order;
            this.orderPerKm = orderPerkm;

            Total = order * orderPerkm;
        }

        public int Order { get => order; set => order = value; }
        public int OrderPerKm { get => orderPerKm; set => orderPerKm = value; }

        public override string ToString()
        {
            return $"no police: {this.NoPolice}, vehicle type: {this.VehicleType}, year: {this.Year}, price: {this.Price}, tax: {this.Tax}, seat: {this.Seat}, transaction date: {this.TransactionDate}, order: {order}, order/KM: {orderPerKm}, total: {this.Total}";
        }
    }
}
