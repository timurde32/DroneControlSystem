using DroneControlSystem;

Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15),
    new Drone("DJI Mavic 3")
};

while (true)
{
    Console.WriteLine("\n=== Система управления БПЛА (версия 3.0) ===");
    Console.WriteLine("1. Информация о всех дронах");
    Console.WriteLine("2. Взлёт дрона");
    Console.WriteLine("3. Подзарядка дрона");
    Console.WriteLine("4. Расчёт времени полёта");
    Console.WriteLine("0. Выход");

    Console.Write("Выберите действие: ");

    if (!int.TryParse(Console.ReadLine(), out int command))
    {
        Console.WriteLine("Введите число.");
        continue;
    }

    if (command == 0)
    {
        break;
    }

    if (command == 1)
    {
        foreach (Drone drone in drones)
        {
            drone.PrintInfo();
            Console.WriteLine();
        }
        continue;
    }

    if (command < 2 || command > 4)
    {
        Console.WriteLine("Неизвестная команда.");
        continue;
    }

    for (int i = 0; i < drones.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drones[i].Model}");
    }

    Console.Write("Выберите дрон: ");

    if (!int.TryParse(Console.ReadLine(), out int index)
        || index < 1 || index > drones.Length)
    {
        Console.WriteLine("Неверный номер дрона.");
        continue;
    }

    Drone selectedDrone = drones[index - 1];

    switch (command)
    {
        case 2:
            selectedDrone.TakeOff();
            break;

        case 3:
            Console.Write("На сколько процентов зарядить: ");

            if (int.TryParse(Console.ReadLine(), out int amount)
                && amount > 0 && amount <= 100)
            {
                selectedDrone.ChargeBattery(amount);
            }
            else
            {
                Console.WriteLine("Неверное значение.");
            }
            break;

        case 4:
            Console.WriteLine($"Время полёта: {selectedDrone.CalculateFlightTime()} мин.");
            break;
    }
}