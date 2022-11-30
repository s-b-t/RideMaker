public class Vehicle
{
    // Descriptive Fields
    public string name;
    public int numberOfPassengers;
    public string color;
    public bool hasEngine;
    public int topSpeed;
    public double milesTraveled;

    // Constructor 1 -- More user input: All fields except milesTraveled
    public Vehicle(string n, int nop, string c, bool he, int ts)
    {
        name = n;
        numberOfPassengers = nop;
        color = c;
        hasEngine = he;
        topSpeed = ts;
        milesTraveled = 0;
    }
    // Constructor 2 -- Basic user input: Name and Color
    public Vehicle(string n, string c)
    {
        name = n;
        numberOfPassengers = 4;
        color = c;
        hasEngine = true;
        topSpeed = 120;
        milesTraveled = 0;
    }

    // Methods
    public void ShowInfo()
    {
        System.Console.WriteLine($"Here is the info on your {name}:");
        Console.WriteLine($"Max Number of Passengers - {numberOfPassengers}, Color - {color}, Top Speed - {topSpeed}mph, Miles - {milesTraveled}mi");
        System.Console.WriteLine("======================");
    }

    public void Travel(double distanceTraveled)
    {
        milesTraveled += distanceTraveled;
    }
}

