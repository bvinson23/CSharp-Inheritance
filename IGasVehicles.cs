namespace Inheritance
{
    public interface IGasVehicles
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
        int CurrentTankPercentage { get; set; }
    }
}