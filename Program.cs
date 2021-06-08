using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram Classic1500 = new Ram();

            List<IElectricVehicles> electricVehicles = new List<IElectricVehicles>
            {
                fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicles ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicles ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /**********************************************/

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>()
            {
                Classic1500, mx410
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            fxs.MainColor = "Silver";
            modelS.MainColor = "Blue";
            mx410.MainColor = "White";
            Classic1500.MainColor = "Red";

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();

            Classic1500.Drive();
            Classic1500.Turn("left");
            Classic1500.Stop();
            Console.WriteLine();
        }
    }
}
