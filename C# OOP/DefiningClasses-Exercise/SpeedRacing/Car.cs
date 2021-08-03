using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {

        public Car(string model, double fm, double fcpk)
        {
            Model = model;
            FuelAmount = fm;
            FuelConsumptionPerKilometer = fcpk;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(Car car, double amountOfKm)
        {
            double fuelReduced = amountOfKm * car.FuelConsumptionPerKilometer;
            if (car.FuelAmount >= fuelReduced)
            {
                car.FuelAmount -= fuelReduced;
                car.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
