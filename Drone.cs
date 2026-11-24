namespace DroneControlSystem;

public class Drone
{
    public string Model { get; set; }
    public int BatteryLevel { get; set; }
    public double Altitude { get; set; }
    public bool IsEngineOn { get; set; }

    private const int BatteryConsumptionPerMinute = 2;
    public Drone() : this("Неизвестный дрон", 100)
{
}

    public Drone(string model, int batteryLevel)
    {
        Model = model;
        BatteryLevel = batteryLevel;
        Altitude = 0;
        IsEngineOn = false;
    }

    public Drone(string model) : this(model, 100)
    {
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Заряд батареи: {BatteryLevel}%");
        Console.WriteLine($"Высота: {Altitude} м");
        Console.WriteLine($"Двигатель: {(IsEngineOn ? "включён" : "выключен")}");
    }

    public void TakeOff()
    {
        if (BatteryLevel < 20)
        {
            Console.WriteLine("Недостаточно заряда.");
            return;
        }

        IsEngineOn = true;
        Altitude = 10;
        BatteryLevel -= 5;
        Console.WriteLine("Взлёт выполнен.");
    }

    public void ChargeBattery(int amount)
    {
        BatteryLevel += amount;

        if (BatteryLevel > 100)
        {
            BatteryLevel = 100;
        }

        Console.WriteLine($"Заряд после подзарядки: {BatteryLevel}%");
    }

    public int CalculateFlightTime()
    {
        if (!IsEngineOn)
        {
            Console.WriteLine("Двигатель выключен.");
            return 0;
        }

        return BatteryLevel / BatteryConsumptionPerMinute;
    }
   
}