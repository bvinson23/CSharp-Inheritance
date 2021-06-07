using System;

namespace Inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($" The {MainColor} vehicle drives past. Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }
    }
}