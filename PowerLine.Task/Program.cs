using PowerLine.Tasks.Models;

Car car = new(fuelTankVolume: 60,
              fuelLevel: 21,
              avarageFuelConsumption: 13.2,
              speed: 60,
              type: VehicleType.Sedan,
              maxPassengersQuantity: 4);

Console.WriteLine($"Запас хода на полном баке {car.PowerReserve(true)} км");
Console.WriteLine($"Запас хода на текущем уровне топлива {car.PowerReserve(false)} км");
Console.WriteLine($"Запас хода c 3 пассажирами {car.PowerReserveWithPassengers(3)} км\n");

FreightCar fc = new(fuelTankVolume: 250,
                    fuelLevel: 75,
                    avarageFuelConsumption: 18.7,
                    speed: 40,
                    type: VehicleType.FreightCar,
                    loadCapacity: 5000);

Console.WriteLine($"Запас хода на полном баке {fc.PowerReserve(true)} км");
Console.WriteLine($"Запас хода на текущем уровне топлива {fc.PowerReserve(false)} км");
Console.WriteLine($"Запас хода c 1000 кг грузом {fc.PowerReserveWithCargo(1000)} км");
