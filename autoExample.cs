using System;

// Abstract class
public abstract class Automobile
{
    // Private fields
    private int numDoors = 4;
    private int numWheels = 4;

    // Public properties to expose data safely
    public int NumDoors
    {
        get => numDoors;
        protected set
        {
            if (value > 0) numDoors = value;
        }
    }

    public int NumWheels
    {
        get => numWheels;
        protected set
        {
            if (value > 0) numWheels = value;
        }
    }

    // Abstract method to be implemented by subclasses
    public abstract void Drive();
}

// Concrete class
public class Car : Automobile
{
    // Override Drive method
    public override void Drive()
    {
        Console.WriteLine("Driving...");
    }
}

// Concrete brand-specific class
public class Ford : Car
{
    // Private field with a public getter
    private string model;

    public string Model
    {
        get => model;
        private set
        {
            if (!string.IsNullOrWhiteSpace(value))
                model = value;
        }
    }

    // Constructor
    public Ford(string model)
    {
        Model = model;

        // Example of modifying protected members
        NumDoors = 2; // e.g., a sports model
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Ford {Model} with {NumDoors} doors and {NumWheels} wheels.");
    }
}

// Entry point
class Program
{
    static void Main()
    {
        Ford mustang = new Ford("Mustang");
        mustang.DisplayInfo();
        mustang.Drive();

        // Invalid: direct access to private/protected members is not allowed outside the class hierarchy
        // mustang.numDoors = 6;        ❌
        // mustang.Model = "Fusion";    ❌
    }
}
