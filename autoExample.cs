using System;

// Abstract class
public abstract class Automobile
{
    public int NumDoors { get; set; } = 4;
    public int NumWheels { get; set; } = 4;

    public abstract void Drive();
}

// Concrete class
public class Car : Automobile
{
    public override void Drive()
    {
        Console.WriteLine("Driving...");
    }
}

// Ford implementation
public class Ford : Car
{
    public string Model { get; set; }

    public Ford(string model)
    {
        Model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Ford {Model} with {NumDoors} doors and {NumWheels} wheels.");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Ford myFord = new Ford("Mustang");
        myFord.DisplayInfo();
        myFord.Drive();
    }
}

