using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Frog : Animal
    {
        private const string animalType = "Frog";
        public Frog(string name, int age, string gender)
            :base(name, age, gender)
        {

        }

        public override string AnimalType => animalType;

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
