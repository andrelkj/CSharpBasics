namespace CSharpBasics.Basics;

public class Calls
{
    /*
     * There are 2 methods os executing calls with C#:
     * - Call by Value - creates a copy of the original value that can be manipulated inside the method scope without changing the original value itself
     * - Call by Reference - creates a reference to the original value which modifies the original value itself even if it is outside the method scope
     */
    public static void CallByValue(int num)
    {
        num = 10;
    }
    
    public static void CallByReference(ref int num)
    {
        num = 10;
    }

    static void Main(string[] args)
    {
        // Call by value - modify a copy of the original value only inside the method scope
        Console.WriteLine("Call by value:");
        
        int num = 5;
        Console.WriteLine($"Number before CallByValue() is executed: {num}");
        
        CallByValue(num);
        Console.WriteLine($"Number after CallByValue() is executed: {num}");
        
        Console.WriteLine("------------------------------");
        
        // Call by reference - modify the original value directly independently of it's position
        Console.WriteLine("Call by reference:");
        
        num = 5;
        Console.WriteLine($"Number before CallByReference() is executed: {num}");
        
        CallByReference(ref num);
        Console.WriteLine($"Number after CallByReference() is executed: {num}");
    }
}