using System;

namespace Inheritance
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooooowwww!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero leans into the {direction} turn.");
        }
    }
}