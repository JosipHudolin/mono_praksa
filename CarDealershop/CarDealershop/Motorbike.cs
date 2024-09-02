using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershop
{
    public class Motorbike : Vehicle
    {

        public Motorbike(int id, string make, string model, int year, double price, int mileage, DateTime? inputTime)
            : base(id, make, model, year, price, mileage, inputTime)
        { }

        public override string GetVehicleDetails()
        {
            return $"{Id} {Year} {Make} {Model}, Price: {Price:C}, Mileage: {Mileage} miles, Input Time: {InputTime}";
        }
    }
}
