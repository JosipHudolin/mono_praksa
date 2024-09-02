using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershop
{
    public abstract class Vehicle: IDiscountable
    {
        public int Id { get; private set; }
        public string? Make { get; private set; }
        public string? Model { get; private set; }
        public int? Year { get; private set; }
        public double? Price { get; protected set; }
        public int? Mileage { get; protected set; }
        public DateTime? InputTime { get; protected set; }

        public Vehicle(int id, string make, string model, int year, double price, int mileage, DateTime? inputTime)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
            InputTime = inputTime;
        }

        public abstract string GetVehicleDetails();

        public void UpdateMileage(int additionalMiles)
        {
            Mileage += additionalMiles;
        }
        public void ApplyDiscount(double discount)
        {
            Price -= ((discount / 100) * Price);
        }
    }

}
