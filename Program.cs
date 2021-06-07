using System;

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
