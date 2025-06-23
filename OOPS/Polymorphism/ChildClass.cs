namespace CSharpBasics.OOPS.Polymorphism;

public class ChildClass : Polymorphism
{
    // The same method can be defined inside a child class, and it will override the original parent method
    public override void OverridingMethod(string message)
    {
        Console.WriteLine($"This is the overridden method defined in the child class, called from: {message}");
    }

    // Covariant
    public override ChildClass MethodName(string input)
    {
        ChildClass childClass = new ChildClass(); // now that ChildClass is abstract it cannot be instantiated
        Console.WriteLine("This will create an instance of the child method and return it as the method return type.");
        return childClass;
    }
    
    // Abstract method declared inside the parent class now requires an override since it isn't defined yet
    public override void AbstractMethod()
    {
        Console.WriteLine("This is the overriden abstract method defined in the parent class.");
    }

    public void ChildOnlyMethod()
    {
        Console.WriteLine("This is a method defined only in the child class.");   
    }

    static void Main(string[] args)
    {
        // Polymorphism polymorphism = new Polymorphism(); // now that ParentClass is abstract, it cannot be instantiated
        ChildClass childClass = new ChildClass();
        Polymorphism polymorphism = new ChildClass(); // uses polymorphic reference to access the parent methods

        // Overriding polymorphism
        Console.WriteLine("Overriding polymorphism:\n");
        // polymorphism.OverridingMethod("Child Class"); // original parent method
        childClass.OverridingMethod("Child Class"); // overridden child method
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Overriding polymorphism and changing the return type:\n");
        childClass.MethodName("Child Class"); // overridden child method
        
        Console.WriteLine("------------------------------");
        // Abstract methods and polymorphic reference
        Console.WriteLine("Abstract methods and polymorphic reference:\n");
        
        polymorphism.AbstractMethod(); // this method is found since it is shared between parent and child classes
        // polymorphism.ChildOnlyMethod(); // this method is not found since it is only defined in the child class
        childClass.ChildOnlyMethod();
    }
}