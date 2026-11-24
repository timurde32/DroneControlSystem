<<<<<<< HEAD
﻿using DroneControlSystem;

Console.WriteLine("*******************************************");
Console.WriteLine("*** Система управления БПЛА (версия 1.0) ***");
Console.WriteLine("*******************************************");

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
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("1 - Взлёт");
    Console.WriteLine("2 - Расчёт времени полёта");
    Console.WriteLine("3 - Подзарядка");
    Console.WriteLine("0 - Выход");

    Console.Write("Введите команду: ");

    if (!int.TryParse(Console.ReadLine(), out int command))
    {
        Console.WriteLine("Ошибка: введите число.");
        continue;
    }

    try
    {
        if (command == 1)
        {
            drones[0].TakeOff();
        }
        else if (command == 2)
        {
            Console.WriteLine($"Время полёта: {drones[0].CalculateFlightTime()} мин.");
        }
        else if (command == 3)
        {
            drones[0].ChargeBattery(50);
        }
        else if (command == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Неизвестная команда.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}
Console.WriteLine("*******************************************");
Console.WriteLine("*** Система управления БПЛА (версия 2.0) ***");
Console.WriteLine("*******************************************");

