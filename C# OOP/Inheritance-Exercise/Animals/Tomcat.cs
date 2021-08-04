using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string gender = "Male";
        private const string animalType = "Tomcat";

        public Tomcat(string name, int age)
            : base(name, age, null)
        {

        }

        public override string Gender => gender;
        public override string AnimalType => animalType;


        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
