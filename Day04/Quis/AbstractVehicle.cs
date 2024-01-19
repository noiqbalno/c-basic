using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Quis
{
    internal abstract class AbstractVehicle
    {

        private string noPolice;
        private string vehicleType;
        private int year;
        private long price;
        private int tax;
        private int seat;

        protected AbstractVehicle(string noPolice, string vehicleType, int year, long price, int tax, int seat)
        {
            this.noPolice = noPolice;
            this.vehicleType = vehicleType;
            this.year = year;
            this.price = price;
            this.tax = tax;
            this.seat = seat;
        }

        public string NoPolice { get => noPolice; set => noPolice = value; }
        public string VehicleType { get => vehicleType; set => vehicleType = value; }
        public int Year { get => year; set => year = value; }
        public long Price { get => price; set => price = value; }
        public int Tax { get => tax; set => tax = value; }
        public int Seat { get => seat; set => seat = value; }

        public override string ToString()
        {
            return $"no police: {noPolice}, vehicle type: {vehicleType}, year: {year}, price: {price}, tax: {tax}, seat: {seat}";
        }
    }
}
