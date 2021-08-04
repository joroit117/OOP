using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string gender = "Female";
        private const string animalType = "Kitten";

        public Kitten(string name, int age)
            :base(name, age, null)
        {

        }

        public override string Gender => gender;
        public override string AnimalType => animalType;


        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
