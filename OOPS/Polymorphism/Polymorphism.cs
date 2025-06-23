namespace CSharpBasics.OOPS.Polymorphism;

public abstract class Polymorphism
{
    /*
     * Polymorphism - same name as the class plus multiple forms (Actions / Behavior).
     *
     * Types of Polymorphism:
     * 1. Compile time / Early binding / Static binding / Overloading - allow classes to have multiple methods with the same name and different parameters.
     * In overloading each method can differ in number and type of parameters which allow different behaviors for same method based on its inputs.
     * 
     * 2. Runtime / Late binding / Dynamic binding / Overriding - different classes with the same signature (parameters). There must be inheritance for overriding to work.
     * In overriding the same method is called with different parameters and behaves accordingly. Same as overloading, you cannot change the return type of the class still.
     *
     * Note: an alternative approach is to use covariant where the class names as return type if you need to change the return type of overriden classes.
     *
     * Another important topic is when you want to instantiate a child class using the type of the parent class called as polymorphic reference
     * ParentClass instance = new ChildClass(); // polymorphic reference
     *
     * Abstract methods - declared with the abstract keyword which doesn't have a body
     * Abstract class
     * 1. We cannot create objects of abstract classes
     * 2. Abstract classes can contain non-abstract methods
     * 3. It is possible to create Constructors inside abstract classes
     * 
     * Interface - used to declare abstract methods that are not defined only. Then other classes can refer to the interface and define each method
     * Multiple inheritance
     */

    // Overloading polymorphism
    public static void OverloadingMethod(string input)
    {
        Console.WriteLine($"This is a method with a string input: {input}");
    }
    
    public static void OverloadingMethod(string input, int number)
    {
        Console.WriteLine($"This is the same method but with a string input: {input} and a number input: {number}");
    }
    
    public static void OverloadingMethod(int number, string input)
    {
        Console.WriteLine($"This is the same method again but with a inverted inputs for number: {number} and string: {input}");
    }

    public static void OverloadingMethod(string input, double number)
    {
        Console.WriteLine($"This is the same method again but with a string input: {input} and a double input: {number}");   
    }

    // Overloading method by changing the return type is not valid and returns a error since it causing conflict with the existing method
    // public static string OverloadingMethod(string input)
    // {
    //     return input;
    // }
    
    // Overriding polymorphism
    public virtual void OverridingMethod(string origin)
    {
        Console.WriteLine($"This is the original method defined in the parent class, called from: {origin}");
    }

    // Overriding a method and changing its return type to the actual class instance - Covariant
    public virtual Polymorphism MethodName(string input)
    {
        // Polymorphism polymorphism = new Polymorphism();
        Console.WriteLine("This will create an instance of the parent method and return it as the method return type.");
        return this;
    }
    
    // Declaring an abstract method that without definition that can be overriden by child classes
    public abstract void AbstractMethod();
    
    void Main(string[] args)
    {
        // WriteLine() is a sample of overloading method since it can receive different input values
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Overloading Method:\n");
        
        Console.WriteLine("WriteLine method with input value 1");
        Console.WriteLine("WriteLine method with input value 2");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Calling Overloaded Methods:");
        
        OverloadingMethod("This is a string input");
        OverloadingMethod("This is a string input", 10);
        OverloadingMethod(10, "This is a string input");
        OverloadingMethod("This is a string input", 10.5);
        
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Overriding Method:\n");
        // Polymorphism polymorphism = new Polymorphism();
        OverridingMethod("Parent Class");
        
        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Overriding polymorphism and changing the return type:\n");
        MethodName("Parent Class"); // original parent method
    }
}