namespace PowerLine.Tasks.Models;
public class SportCar : Vehicle
{
    public SportCar(int fuelTankVolume, double speed, double avarageFuelConsumption, VehicleType type, double fuelLevel)
        : base(fuelTankVolume, speed, avarageFuelConsumption, type, fuelLevel)
    {

    }
}