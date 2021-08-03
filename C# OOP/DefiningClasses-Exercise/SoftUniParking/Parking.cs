using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        public List<Car> cars;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count => this.cars.Count;

        public string AddCar(Car Car)
        {
            bool exist = false;

            foreach (var car in cars)
            {
                if (car.RegistrationNumber == Car.RegistrationNumber)
                {
                    exist = true;
                    return "Car with that registration number, already exists!";
                }
            }
            if (!exist)
            {
                if (cars.Count >= capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    cars.Add(Car);

                    return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
                }
            }
            return "";
        }

        public string RemoveCar(string RegistrationNumber)
        {
            bool exist = false;
            foreach (var car in cars)
            {
                if (car.RegistrationNumber == RegistrationNumber)
                {
                    cars.Remove(car);
                    exist = true;
                    return $"Successfully removed {RegistrationNumber}";
                }
            }
            if (!exist)
            {
                return "Car with that registration number, doesn't exist!";
            }
            return "";
        }

        public Car GetCar(string RegistrationNumber)
        {
            foreach (var car in cars)
            {
                if (car.RegistrationNumber == RegistrationNumber)
                {
                    return car;
                }
            }
            return null;
        }

        public void RemoveSetOfRregistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var car in cars)
            {
                foreach (var number in RegistrationNumbers)
                {
                    if (car.RegistrationNumber == number)
                    {
                        cars.Remove(car);
                    }
                }
            }
        }
    }
}
