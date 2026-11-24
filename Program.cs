using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА ===");

Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15)
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