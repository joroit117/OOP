using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        private const string animalType = "Dog";
        public Dog(string name, int age, string gender)
            :base(name, age, gender)
        {

        }
        public override string AnimalType => animalType;


        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
