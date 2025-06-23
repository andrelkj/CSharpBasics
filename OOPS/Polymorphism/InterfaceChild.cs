namespace CSharpBasics.OOPS.Polymorphism;

public class InterfaceChild : IInterface, IInterface2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("Defines the interface method declared in the IInterface");
        Console.WriteLine($"It is also possible to access static variables defined in the interface: {IInterface.X}");
    }
    
    public void SecondInterfaceMethod()
    {
        Console.WriteLine("Defines the second interface method declared in the IInterface2");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Accessing interface methods:\n");
        
        InterfaceChild interfaceChild = new InterfaceChild();
        interfaceChild.InterfaceMethod();
        interfaceChild.SecondInterfaceMethod();
    }
}