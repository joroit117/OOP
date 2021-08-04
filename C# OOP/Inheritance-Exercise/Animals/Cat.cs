using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    
    public class Cat : Animal
    {
        private const string animalType = "Cat";
        public Cat(string name, int age, string gender)
            :base(name, age, gender)
        {

        }

        public override string AnimalType => animalType;

        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }
}
