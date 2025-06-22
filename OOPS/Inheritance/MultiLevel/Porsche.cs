using CSharpBasics.OOPS.Inheritance.Hierarchical;

namespace CSharpBasics.OOPS.Inheritance.MultiLevel;

public class Porsche : Volkswagen //, Car // multiple inheritance is not supported outside Interfaces because of conflicts while identifying the parent class
{
    static void Main(string[] args)
    {
        Porsche porsche = new Porsche();
        porsche.Start();
    }
}