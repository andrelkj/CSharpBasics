namespace CSharpBasics.OOPS.Constructors;

public class Constructors
{
    /*
     * Constructors assume the same name as the class and don't have a return type
     * Its purpose is to initialize newly created objects, and they are automatically called when an instance of a class is created
     *
     * Types of constructors:
     * 1. Default constructor - automatically created by C# if no constructor is manually created
     * 2. No argument constructor - manually created constructor without parameters
     * 3. Parameterized constructor
     */

    // No argument constructor
    public Constructors()
    {
        Console.WriteLine("This is a no argument constructor method call.\n");
    }
    
    // Parameterized constructor        
    string name;
    int age;
    
    public Constructors(string name, int age) : this() //this() will chain the constructor calling it from inside the constructor itself
    {
        this.name = name; // this keywork is used to identify the variable from the actual method (Constructors)
        this.age = age; // this keywork is used to identify the variable from the actual method (Constructors)
        Console.WriteLine($"{name} and {age} are the parameters passed to this constructor.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("No argument constructor method call:\n");
        Constructors constructors = new Constructors();
        
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Parameterized constructor method calls:\n");
        
        Constructors constructors1 = new Constructors("André", 28);
        Constructors constructors2 = new Constructors("Bárbara", 23);
        
        // Accessing variables from the constructor
        Console.WriteLine($"First constructor name is: {constructors1.name}");
        Console.WriteLine($"Second constructor name is: {constructors2.name}");
    }
}