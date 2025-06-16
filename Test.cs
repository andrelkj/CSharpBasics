namespace CSharpBasics;

public class Test
{
    public void TestMethod()
    {
        Console.WriteLine("Inside Test Method");
    }

    static void Main(string[] args) // in C# we can only have one entry point - only one main method is allowed
    {
        Test test = new Test();
        test.TestMethod();
    }
}