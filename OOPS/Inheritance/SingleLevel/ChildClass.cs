namespace CSharpBasics.OOPS.Inheritance;

public class ChildClass : ParentClass // specify that ChildClass is an extension if the ParentClass
{
    public void Display()
    {
        // Whenever the same method is defined on different levels the class will prioritize its own method 
        Console.WriteLine("Message from Child Class");
        base.Display(); // base keyword refers to the parent class but cannot be called from a static method
    }
    
    static void Main(string[] args)
    {
        // Now that the ChildClass have access to properties from the ParentClass, it is possible to use Display() method from it
        ChildClass childClass = new ChildClass();
        childClass.Display();
        // base.Display(); // returns an error since base keyword is only accessible from non-static methods
    }
}