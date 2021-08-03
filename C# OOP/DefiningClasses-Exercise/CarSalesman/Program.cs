using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            int enginesCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(' ');
                
                if (inputEngine.Length == 2)
                {
                    Engine engine = new Engine(inputEngine[0], int.Parse(inputEngine[1]));
                    engines.Add(engine);
                }
                else if (inputEngine.Length == 3)
                {
                    int id = 0;
                    if(int.TryParse(inputEngine[2], out id))
                    {
                        Engine engine = new Engine(inputEngine[0], int.Parse(inputEngine[1]), int.Parse(inputEngine[2]));
                        engines.Add(engine);
                    }
                    else
                    {
                        Engine engine = new Engine(inputEngine[0], int.Parse(inputEngine[1]), inputEngine[2]);
                        engines.Add(engine);
                    }
                }
                else if (inputEngine.Length == 4)
                {
                    Engine engine = new Engine(inputEngine[0], int.Parse(inputEngine[1]), int.Parse(inputEngine[2]), inputEngine[3]);
                    engines.Add(engine);
                }
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for(int i = 0; i < carCount; i++)
            {
                string[] inputCar = Console.ReadLine().Split(' ');

                foreach(var engine in engines)
                {
                    if(inputCar[1] == engine.Model)
                    {
                        if (inputCar.Length == 2)
                        {
                            Car car = new Car(inputCar[0], engine);
                            cars.Add(car);
                        }
                        else if (inputCar.Length == 3)
                        {
                            int id = 0;
                            if(int.TryParse(inputCar[2], out id))
                            {
                                Car car = new Car(inputCar[0], engine, int.Parse(inputCar[2]));
                                cars.Add(car);
                            }
                            else
                            {
                                Car car = new Car(inputCar[0], engine, inputCar[2]);
                                cars.Add(car);
                            }
                            
                        }
                        else if (inputCar.Length == 4)
                        {
                            Car car = new Car(inputCar[0], engine, int.Parse(inputCar[2]), inputCar[3]);
                            cars.Add(car);
                        }
                        break;
                    }
                }
            }

            foreach(var car in cars)
            {
                Console.WriteLine(car.Model + ":");
                Console.WriteLine(" " + car.Engine.Model + ":");
                Console.WriteLine("  Power: " + car.Engine.Power);
                if(car.Engine.Displacement == 0)
                {
                    Console.WriteLine("  Displacement: n/a");
                }
                else
                {
                    Console.WriteLine("  Displacement: " + car.Engine.Displacement);

                }
                if(car.Engine.Efficiency == null)
                {
                    Console.WriteLine("  Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine("  Efficiency: " + car.Engine.Efficiency);
                }
                if (car.Weight == 0)
                {
                    Console.WriteLine(" Weight: n/a");
                }
                else
                {
                    Console.WriteLine(" Weight: " + car.Weight);
                }
                if (car.Color == null)
                {
                    Console.WriteLine(" Color: n/a");
                }
                else
                {
                    Console.WriteLine(" Color: " + car.Color);
                }
            }

        }
    }
}
