using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershop
{
    public class Car : Vehicle
    {
        public string BodyStyle { get; private set; }

        public Car(int id, string make, string model, int year, double price, int mileage,DateTime? inputTime, string bodyStyle)
            : base(id, make, model, year, price, mileage, inputTime)
        {
            BodyStyle = bodyStyle;
        }

        public override string GetVehicleDetails()
        {
            return $"{Id} {Year} {Make} {Model} ({BodyStyle}), Price: {Price}, Mileage: {Mileage} miles, Input Time: {InputTime}";
        }
    }

}
