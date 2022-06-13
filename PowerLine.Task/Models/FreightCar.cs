namespace PowerLine.Tasks.Models;
public class FreightCar : Vehicle
{
    public FreightCar(int fuelTankVolume,
                      double fuelLevel,
                      double avarageFuelConsumption,
                      double speed,
                      VehicleType type,
                      int loadCapacity) : base(fuelTankVolume, speed, avarageFuelConsumption, type, fuelLevel)
    {
        LoadCapacity = loadCapacity;
    }

    // грузоподъёмность
    public int LoadCapacity { get; init; }

    /// <summary>
    /// Метод для вычисления запас хода с грузом
    /// </summary
    /// <param name="weight">Вес груза</param>
    /// <returns>Запас хода в километрах</returns>
    public double PowerReserveWithCargo(int weight)
    {
        if (weight > LoadCapacity)
            throw new Exception($"Этот грузовик не может принять больше ${LoadCapacity} килограммов");

        var powerReseerve = PowerReserve();

        return powerReseerve - (powerReseerve * 0.04 * weight / 200);
    }
}