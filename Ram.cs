using System;

namespace Inheritance
{
    public class Ram : Vehicle // gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("RRrrrrrummbbble!");
        }
    }
}