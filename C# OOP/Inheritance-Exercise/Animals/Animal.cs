using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string AnimalType { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual string Gender { get; set; }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(this.GetType().Name)
                .AppendLine($"{Name} {Age} {Gender.ToString()}")
                .Append($"{ProduceSound()}");

            return builder.ToString();
        }
    }
}
