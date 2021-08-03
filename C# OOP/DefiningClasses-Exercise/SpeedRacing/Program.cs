using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' '); 
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] input = command.Split(' ');
                string carModel = input[1];
                double amountOfKm = double.Parse(input[2]);
                foreach(var c in cars)
                {
                    if(c.Model == carModel)
                    {
                        c.Drive(c, amountOfKm);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var c in cars)
            {
                Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.TravelledDistance}");
            }
        }
    }
}
