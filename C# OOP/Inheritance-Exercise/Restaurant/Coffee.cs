using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : Beverage
    {
        private const double milliliters = 50;
        private const decimal price = 3.50M;
        public Coffee(string name, double caffeine)
            : base(name, 0, 0)
        {
            Caffeine = caffeine;
        }

        public override double Milliliters
            => milliliters;
        public override decimal Price
            => price;
        public double Caffeine { get; set; }
    }
}
