using System;
using System.Collections.Generic;

namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var carTires = new List<Tire[]>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                
                var currentTires = new Tire[4]
                {
                    new Tire(double.Parse(input[5]), int.Parse(input[6])),
                    new Tire(double.Parse(input[7]), int.Parse(input[8])),
                    new Tire(double.Parse(input[9]), int.Parse(input[10])),
                    new Tire(double.Parse(input[11]), int.Parse(input[12]))
                };

                carTires.Add(currentTires);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, currentTires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if(command == "flamable")
            {
                foreach(var car in cars)
                {
                    if(car.Cargo.Type == "flamable")
                    {
                        if(car.Engine.Power > 250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
            else if(command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.Type == "fragile")
                    {
                        bool allLessThan1 = true;
                        foreach(var tire in car.Tires)
                        {
                            if(tire.Pressure >= 1)
                            {
                                allLessThan1 = false;
                                break;
                            }
                        }
                        if(allLessThan1)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                }
            }
        }
    }
}
