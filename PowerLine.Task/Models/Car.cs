namespace PowerLine.Tasks.Models;
public class Car : Vehicle
{
    public Car(int fuelTankVolume,
               double fuelLevel,
               double avarageFuelConsumption,
               double speed,
               VehicleType type,
               int maxPassengersQuantity) : base(fuelTankVolume, speed, avarageFuelConsumption, type, fuelLevel)
    {
        MaxPassengersQuantity = maxPassengersQuantity;
    }

    public int MaxPassengersQuantity { get; init; }

    /// <summary>
    /// Метод для вычисления запас хода с учётом пассажиров
    /// </summary
    /// <param name="passengerQuantity">Количество пассажиров</param>
    /// <returns>Запас хода в километрах</returns>
    public double PowerReserveWithPassengers(int passengerQuantity)
    {
        if (passengerQuantity > MaxPassengersQuantity)
            throw new Exception($"Эта машина не может принять больше {MaxPassengersQuantity} пассажиров");

        var powerReverse = base.PowerReserve();

        return powerReverse - (powerReverse * 0.06 * passengerQuantity);
    }
}