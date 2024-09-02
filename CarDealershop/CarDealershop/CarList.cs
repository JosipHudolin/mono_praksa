using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershop
{
    internal class CarList
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void AddCar(Vehicle vehicle) { vehicles.Add(vehicle); }

        public void DeleteCar(int id) {
            int selectedIndex = -1;
            for (int i = 0; i < vehicles.Count; i++) { 
                if (vehicles[i].Id == id)
                {
                    selectedIndex = i;
                }
            }
            vehicles.RemoveAt(selectedIndex);
        }

        public string GetAllVehicles()
        {
            StringBuilder result = new StringBuilder();

            foreach (Vehicle vehicle in vehicles)
            {
                result.Append(vehicle.GetVehicleDetails() + "\n");
            }

            string finalResult = result.ToString();
            if (finalResult == "")
            {
                finalResult = "There are no vehicles in shop right now!";
            }

            return finalResult;
        }

        public string GetFilteredVehicles(string vehicleMake)
        {
            StringBuilder result = new StringBuilder();
            string carMakeToLower = vehicleMake.ToLower();

            foreach (Vehicle vehicle in vehicles) {
                string OriginalCarMakeToLower = vehicle.Make.ToLower();
                if (OriginalCarMakeToLower == carMakeToLower) {
                    result.Append(vehicle.GetVehicleDetails() + "\n");
                }
            }
            string finalResult = result.ToString();
            if (finalResult == "")
            {
                finalResult = "There are no vehicles in shop right now!";
            }
            return finalResult;
        }
        public string GetCars()
        {
            StringBuilder result = new StringBuilder();
            foreach (Vehicle vehicle in vehicles) {
                if (vehicle is Car car)
                {
                    result.Append(car.GetVehicleDetails() + "\n");
                }
            }
            string finalResult = result.ToString();
            if (finalResult == "")
            {
                finalResult = "There are no cars in shop right now!";
            }
            return finalResult;
        }

        public string GetMotorbikes()
        {
            StringBuilder result = new StringBuilder();
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Motorbike motorbike)
                {
                    result.Append(motorbike.GetVehicleDetails() + "\n");
                }
            }
            string finalResult = result.ToString();
            if (finalResult == "")
            {
                finalResult = "There are no motorbikes in shop right now!";
            }
            return finalResult;
        }
        public int GetVehicleLength()
        {
            return vehicles.Count;
        }
    }
}
