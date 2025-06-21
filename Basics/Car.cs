namespace CSharpBasics.Basics;

public class Car
{
    private string Color;
    private string Brand;

    public void Accelerate()
    {
        Console.WriteLine("The car is accelerating...");
    }

    public void Break()
    {
        Console.WriteLine("The car braked!");   
    }

    static void Main(string[] args) // in C# we can only have one entry point - only one main method is allowed
    {
        Car car = new Car();
        car.Break();
        car.Color = "Red";
        car.Brand = "BMW";
        car.Accelerate();
    }
}