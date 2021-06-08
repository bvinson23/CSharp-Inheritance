using System;

namespace Inheritance
{
    public class Tesla : Vehicle, IElectricVehicles // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla propels by you. MMmmmmmmmmmm!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla quietly halts.");
        }
    }
}