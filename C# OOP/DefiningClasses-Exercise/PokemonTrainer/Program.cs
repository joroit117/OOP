using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp

    {
        static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();
            while(command != "Tournament")
            {
                bool exist = false;

                string[] input = command.Split(' ');

                Pokemon pokemon = new Pokemon(input[1], input[2], int.Parse(input[3]));

                Trainer trainer = new Trainer(input[0], 0, new List<Pokemon>());

                foreach(var t in trainers)
                { 
                    if(t.Name == trainer.Name)
                    {
                        t.Collection.Add(pokemon);
                        exist = true;
                        break;
                    }
                }
                if(exist)
                {
                    exist = false;
                }
                else
                {
                    trainers.Add(trainer);
                    foreach(var t in trainers)
                    {
                        if (t.Name == trainer.Name)
                        {
                            t.Collection.Add(pokemon);
                        }
                    }
                }
                
                command = Console.ReadLine();
            }

            string element = Console.ReadLine();
            while(element != "End")
            {
                bool hasOneAtLeast = false;
                switch (element)
                {
                    case "Fire":
                        foreach (var trainer in trainers)
                        {
                            foreach(var el in trainer.Collection)
                            {
                                if (el.Element == "Fire")
                                {
                                    hasOneAtLeast = true;
                                    break;
                                }
                            }
                            if (hasOneAtLeast)
                            {
                                trainer.NumberOfBadges++;
                                hasOneAtLeast = false;
                            }
                            else
                            {
                                foreach (var el in trainer.Collection.ToList())
                                {
                                    el.Health -= 10;
                                    if (el.Health <= 0)
                                    {
                                        trainer.Collection.Remove(el);
                                    }
                                }
                            }
                        }
                        break;
                    case "Water":
                        foreach (var trainer in trainers)
                        {
                            foreach (var el in trainer.Collection)
                            {
                                if (el.Element == "Water")
                                {
                                    hasOneAtLeast = true;
                                    break;
                                }
                            }
                            if (hasOneAtLeast)
                            {
                                trainer.NumberOfBadges++;
                                hasOneAtLeast = false;
                            }
                            else
                            {
                                foreach (var el in trainer.Collection.ToList())
                                {
                                    el.Health -= 10;
                                    if (el.Health <= 0)
                                    {
                                        trainer.Collection.Remove(el);
                                    }
                                }
                            }
                        }
                        break;
                    case "Electricity":
                        foreach (var trainer in trainers)
                        {
                            foreach (var el in trainer.Collection)
                            {
                                if (el.Element == "Electricity")
                                {
                                    hasOneAtLeast = true;
                                    break;
                                }
                            }
                            if (hasOneAtLeast)
                            {
                                trainer.NumberOfBadges++;
                                hasOneAtLeast = false;
                            }
                            else
                            {
                                foreach (var el in trainer.Collection.ToList())
                                {
                                    el.Health -= 10;
                                    if (el.Health <= 0)
                                    {
                                        trainer.Collection.Remove(el);
                                    }
                                }
                            }
                        }
                        break;
                }
                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Collection.Count}");
            }
        }
    }
}
