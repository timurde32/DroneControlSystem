using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===");

Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15),
    new Drone("DJI Mavic 3")
};

foreach (Drone drone in drones)
{
    drone.PrintInfo();

    if (drone.BatteryLevel < 20)
    {
        Console.WriteLine("Внимание! Низкий заряд батареи.");
    }

    Console.WriteLine();
}

for (int i = 0; i < drones.Length; i++)
{
    if (drones[i].BatteryLevel < 50)
    {
        Console.WriteLine($"Подзарядить {drones[i].Model}? (1 - да, 0 - нет)");

        if (Console.ReadLine() == "1")
        {
            drones[i].ChargeBattery(50);
        }
    }
}

Console.WriteLine("Выполнить взлёт первого дрона? (1 - да, 0 - нет)");

if (Console.ReadLine() == "1")
{
    drones[0].TakeOff();
}

Console.WriteLine("Программа завершена.");