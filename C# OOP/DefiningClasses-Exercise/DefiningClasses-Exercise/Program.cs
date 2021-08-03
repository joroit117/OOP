using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {


            var listPeople = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                listPeople.Add(person);
            }

            var sortedPeople = listPeople.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach(var p in sortedPeople)
            {
                Console.WriteLine(p.Name + " - " + p.Age);
            }

            return;
            Person person4 = new Person("Hugo", 39);
            Console.WriteLine(person4.Name + " " + person4.Age);
            return;
            Person person1 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;

            Person person2 = new Person
            {
                Name = "George",
                Age = 18
            };

            Person person3 = new Person
            {
                Name = "Sam",
                Age = 43
            };

        }
    }
}
