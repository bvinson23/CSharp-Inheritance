namespace Inheritance
{
    public interface IElectricVehicles
    {
        double BatteryKWh { get; set; }
        void ChargeBattery();
        int CurrentChargePercentage { get; set; }
    }
}