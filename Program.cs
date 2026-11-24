using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===");

Drone myDrone = new Drone("DJI Mini 3", 85);

myDrone.PrintInfo();
Console.WriteLine();

Console.Write("Введите команду (1 — взлёт, 0 — выход): ");
int command = int.Parse(Console.ReadLine());

while (command != 0)
{
    if (command == 1)
    {
        myDrone.TakeOff();
    }
    else
    {
        Console.WriteLine("Неизвестная команда.");
    }

    Console.Write("Введите команду (1 — взлёт, 0 — выход): ");
    command = int.Parse(Console.ReadLine());
}

Console.WriteLine("Программа завершена.");
