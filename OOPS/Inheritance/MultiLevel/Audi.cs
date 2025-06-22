using CSharpBasics.OOPS.Inheritance.Hierarchical;

namespace CSharpBasics.OOPS.Inheritance.MultiLevel;

public class Audi : Volkswagen // Audi is a multi-level inheritance class since it is a child of another child
{
    static void Main(string[] args)
    {
        Audi audi = new Audi();
        audi.Start();
    }
}