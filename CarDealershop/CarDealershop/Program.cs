using CarDealershop;
Console.WriteLine("Welcome to our dealershop!");
CarList vehicleList = new CarList();

while (true)
{
    Console.WriteLine("Please select one of these options:\n");
    Console.WriteLine("1 Add new vehicle");
    Console.WriteLine("2 Sell a vehicle");
    Console.WriteLine("3 List all vehicles");
    Console.WriteLine("4 List filtered vehicles");
    Console.WriteLine("5 List all cars");
    Console.WriteLine("6 List all motorbikes");
    Console.WriteLine("7 Apply discount");
    Console.WriteLine("8 Change mileage");
    Console.WriteLine("9 Exit");

    string? menuSelect = Console.ReadLine();

    switch (menuSelect)
    {
        case "1":
            string? make;
            string? model;
            double price;
            int year;
            int mileage;
            string type;
            int id;
            string bodyStyle;
            Console.WriteLine("Type(Car or Motorbike)");
            type = Console.ReadLine();
            Console.WriteLine("Make: ");
            make = Console.ReadLine();
            Console.WriteLine("Model: ");
            model = Console.ReadLine();
            Console.WriteLine("Price:");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Mileage:");
            mileage = int.Parse(Console.ReadLine());
            id = vehicleList.GetVehicleLength() + 1;
            DateTime? inputTime = DateTime.Now;
            if (type == "Car")
            {
                Console.WriteLine("Bodystyle:");
                bodyStyle = Console.ReadLine();
                Car car = new Car(id, make, model, year, price, mileage, inputTime, bodyStyle);
                vehicleList.AddCar(car);
            }
            else if (type == "Motorbike")
            {
                Motorbike motorbike = new Motorbike(id, make, model, year, price, mileage, inputTime);
                vehicleList.AddCar(motorbike);
            }
            Console.WriteLine();
            break;
        case "2":
            Console.WriteLine("Choose ID for sold car");
            Console.WriteLine(vehicleList.GetAllVehicles());
            int selectedId = int.Parse(Console.ReadLine());
            for (int i = 0; i < vehicleList.vehicles.Count; i++) {
                if (vehicleList.vehicles[i].Id == selectedId)
                    {
                        vehicleList.DeleteCar(selectedId);
                    }
            }
            Console.WriteLine();
            break;
        case "3":
            Console.WriteLine(vehicleList.GetAllVehicles());
            Console.WriteLine();
            break;
        case "4":
            Console.WriteLine("Write the car make:");
            string carMake = Console.ReadLine();
            Console.WriteLine(vehicleList.GetFilteredVehicles(carMake));
            Console.WriteLine();
            break;
        case "5":
            Console.WriteLine(vehicleList.GetCars());
            Console.WriteLine();
            break;
        case "6":
            Console.WriteLine(vehicleList.GetMotorbikes());
            Console.WriteLine();
            break;
        case "7":
            Console.WriteLine("Choose ID of selected vehicle");
            Console.WriteLine(vehicleList.GetAllVehicles());
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Write discount(%)");
            int discount = int.Parse(Console.ReadLine());
            foreach (Vehicle vehicle in vehicleList.vehicles)
            {
                if (id == vehicle.Id)
                {
                    vehicle.ApplyDiscount(discount);
                }
            }
            Console.WriteLine();
            break;
        case "8":
            Console.WriteLine("Choose ID of selected vehicle");
            Console.WriteLine(vehicleList.GetAllVehicles());
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Write mileage");
            int carMileage = int.Parse(Console.ReadLine());
            foreach (Vehicle vehicle in vehicleList.vehicles)
            {
                if (id == vehicle.Id)
                {
                    vehicle.UpdateMileage(carMileage);
                }
            }
            Console.WriteLine();
            break;
        case "9":
            Environment.Exit(0);
            break;
    }
}