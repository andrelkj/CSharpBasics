namespace CSharpBasics.OOPS.Polymorphism;

/*
 * Abstract methods - declared with the abstract keyword which doesn't have a body
 * 
 * Abstract class
 * 1. We cannot create objects of abstract classes
 * 2. Abstract classes can contain non-abstract methods
 * 3. It is possible to create Constructors inside abstract classes
 */

public abstract class Abstract
{
    // abstract methods can only be declared inside abstract classes
    public abstract void AbstractMethod();

    // but it is also possible to declare non abstract methods inside abstract classes
    public void NonAbstractMethod()
    {
        Console.WriteLine("This is a non abstract method");
    }

    static void Main(string[] args)
    {
        // Abstract abstractClass = new Abstract(); // returns a error since its not possible to create objects of an abstract class
    }
}