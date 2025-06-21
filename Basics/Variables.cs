namespace CSharpBasics.Basics; // namespaces identify folders so classes can be imported from external files

public class Variables
{
    /*
     * Variable types and scope
     * 1. Local variables - declared within methods, constructors or blocks - {}. Accessible from within the scope in which they were declared only.
     * 2. Instance variables / Non-static variables - declared inside a class but outside any method. Accessible from any non-static methods in a class, each instance of a class contains a copy of all instance variables.
     * 3. Class variables / Static variables - declared inside a class adding the "static" keywork. Accessible from any instances of the class and have only one copy independently of the number of instances in the class.
     * 4. Constant variables - immutable variables declared adding the "const" keywork that are defined in compile-time, have to be initialized with a value and once declared cannot change their value throughout the program.
     * 5. Readonly variables - immutable variables similar to constants, but can be declared without an initializer. Can be updated only via constructor.
     * 6. Parameter variables - declared in method signatures and allow to pass values to the method itself. Accessible inside the method in which they were declared only.
     */

    string instanceVariable = "This is an instance variable";
    static string classVariable = "This is a class variable";
    readonly string readonlyVariable = "This is a readonly variable.";

    readonly int mutableReadonlyVariable;

    // Changing values of a readonly variable
    public Variables(int i = 0)
    {
        mutableReadonlyVariable = i * 10; // because it is inside a contructor I can update readonly variables value
    }

    public void DoSomething()
    {
        // Local variable
        Console.WriteLine("Local variable:\n");

        string localVariable = "This is a local variable";
        Console.WriteLine($"{localVariable} accessed from inside it's declaration scope.");

        Console.WriteLine("------------------------------");

        // Instance variables 
        Console.WriteLine("Instance variables:\n");
        Console.WriteLine($"{instanceVariable} accessed from inside DoSomething() method.");
    }

    // Parameter variables
    public void Add(int a, int b) // a and b are parameter variables
    {
        int sum = a + b;
        
        Console.WriteLine("Parameter variables:\n");
        Console.WriteLine($"{sum} is the sum of {a} and {b} parameter variables.");
    }
    
    // a = 10; // returns an error since parameter variables can only be accessed within it's declarition method

    public void DoSomethingElse()
    {
        Console.WriteLine($"{instanceVariable} accessed from inside DoSomethingElse() method.");
    }

    static void Main(string[] args)
    {
        Variables variables = new Variables();
        variables.DoSomething();
        variables.DoSomethingElse();

        Console.WriteLine($"{variables.instanceVariable} copied from the original instance variable value.");
        variables.instanceVariable = "This is the variables object instance variable with updated value.";

        Variables newObject = new Variables();
        newObject.instanceVariable = "This is the newObject object instance variable with updated value.";

        Console.WriteLine(variables.instanceVariable);
        Console.WriteLine(newObject.instanceVariable);

        Console.WriteLine("------------------------------");

        // Console.WriteLine(localVariable); // returns an error since localVariable cannot be accessed outside its declaration scope
        // Console.WriteLine(instanceVariable); // returns an error since instanceVariables cannot be accessed from static methods

        // Class variables
        Console.WriteLine("Class variables:\n");
        Console.WriteLine($"{classVariable} accessed from static methods.");

        Console.WriteLine("------------------------------");

        // Constant variables
        Console.WriteLine("Constant variables:\n");
        // const string nullConstantVariable; // returns an error since constant variables require a initializer
        const string constantVariable = "This is a constant variable.";
        // constantVariable = "This is the updated value"; // returns an error since constant variables are immutable
        Console.WriteLine(constantVariable);

        Console.WriteLine("------------------------------");

        // Readonly variables
        Console.WriteLine("Readonly variables:\n");

        // readonlyVariable = "This is the updated value of the readonly variable"; // returns an error since readonly variables are immutable
        Console.WriteLine(variables.readonlyVariable);
        Console.WriteLine($"Changed value of mutableReadonlyVariable: {variables.mutableReadonlyVariable}");

        Console.WriteLine("------------------------------");
        variables.Add(5, 3);
    }
}