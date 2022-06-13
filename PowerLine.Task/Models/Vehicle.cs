namespace PowerLine.Tasks.Models;
public class Vehicle
{
    public Vehicle(int fuelTankVolume, double speed, double avarageFuelConsumption, VehicleType type, double fuelLevel)
    {
        FuelTankVolume = fuelTankVolume;
        AvaregeFuelConsumption = avarageFuelConsumption;
        Type = type;
        Speed = speed;
        FuelLevel = fuelLevel;
    }

    // init для предотвращения изменения типа ТС после создание экземпляра
    public VehicleType Type { get; init; }

    // init для предотвращения изменения объёма бака после создание экземпляра
    public int FuelTankVolume { get; init; }

    //средний расход топлива на 100км
    // значение свойство может изменятся со временем, из-за этого вместо init используется set
    public double AvaregeFuelConsumption { get; init; }

    // доступная топлива в баке
    // значение свойство может изменятся со временем(mutable), из-за этого вместо init используется set
    public double FuelLevel { get; set; }

    // значение свойство может изменятся со временем(mutable), из-за этого вместо init используется set
    public double Speed { get; set; }

    /// <summary>
    /// Метод для вычисления запас хода на полном баке или на остаточном количестве топлива.
    /// </summary
    /// <param name="filledTank">Полный бак</param>
    /// <returns>Запас хода в километрах</returns>
    public double PowerReserve(bool filledTank = false)
    {
        return filledTank ? 100 * FuelTankVolume / AvaregeFuelConsumption : 100 * FuelLevel / AvaregeFuelConsumption;
    }

    /*
        В тестовое задание написано так:
        "Метод, который на основе параметров количества топлива и заданного расстояния вычисляет за сколько автомобиль его преодолеет."
        Непонятно что подразумевается под словом "за сколько". Если это время, то его можно вычислить без параметра количества топлива.
    */
    public double TravelTime(int fuelVolume, double distance)
    {
        if (Speed != 0)
            return distance / Speed;
        return 0;
    }
}