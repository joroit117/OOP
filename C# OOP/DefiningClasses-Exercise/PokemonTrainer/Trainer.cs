using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int numberOfBadges)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
        }

        public Trainer(string name, int numberOfBadges, List<Pokemon> collection)
            :this(name, numberOfBadges)
        {
            Collection = collection;
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Collection { get; set; }

    }
}
