using System;

namespace Inheritance
{
    public class Ram : Vehicle, IGasVehicles // gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. RRrrrrrummbbble!");
        }
    }
}