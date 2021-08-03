using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(int age)
            :this("No name", age)
        {
            Age = age;
        }

        public Person()
            :this("No name", 1)
        {

        }

        public string Name { get; set; }

        public int Age { get; set; }

    }
}
