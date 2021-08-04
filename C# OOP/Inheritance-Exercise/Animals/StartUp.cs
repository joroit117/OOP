using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                

                string command = Console.ReadLine();

                if (command == "Beast!")
                {
                    break;
                }

                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (command)
                    {
                        case "Dog":
                            var dog = new Dog(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(frog);
                            break;
                        case "Cat":
                            var cat = new Cat(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(cat);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(input[0], int.Parse(input[1]));
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(input[0], int.Parse(input[1]));
                            animals.Add(tomcat);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
