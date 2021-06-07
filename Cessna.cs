using System;

namespace Inheritance
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna soars overhead. Zoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}