using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(input[0]), double.Parse(input[1])),
                    new Tire(int.Parse(input[2]), double.Parse(input[3])),
                    new Tire(int.Parse(input[4]), double.Parse(input[5])),
                    new Tire(int.Parse(input[6]), double.Parse(input[7]))
                };

                tires.Add(currTires);

                command = Console.ReadLine();
            }

            var engines = new List<Engine>();

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var engine = new Engine(int.Parse(input[0]), double.Parse(input[1]));
                engines.Add(engine);

                command = Console.ReadLine();
            }

            var cars = new List<Car>();

            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = input[0];
                string model = input[1];
                int year = int.Parse(input[2]);
                double fuelQuantity = double.Parse(input[3]);
                double fuelConsumption = double.Parse(input[4]);
                int engineIndex = int.Parse(input[5]);
                int tireIndex = int.Parse(input[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count) && (tireIndex >= 0 && tireIndex < tires.Count))
                {
                    var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]);
                    cars.Add(car);
                }

                command = Console.ReadLine();
            }

            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    StringBuilder builder = new StringBuilder();

                    car.Drive(20);

                    builder.AppendLine($"Make: {car.Make}");
                    builder.AppendLine($"Model: {car.Model}");
                    builder.AppendLine($"Year: {car.Year.ToString()}");
                    builder.AppendLine($"HorsePowers: {car.Engine.HorsePower.ToString()}");
                    builder.AppendLine($"FuelQuantity: {car.FuelQuantity.ToString()}");

                    Console.Write(builder);
                }
            }
        }
    }
}
