namespace CSharpBasics;

public class JumpStatements
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basics of C# - Jump Statements");

        for (int i = 0; i < 10; i++)
        {
            JumpHere: // This is the label
            
            if (i is > 2 and < 5)
            {
                Console.WriteLine($"Continue statement will skip interaction number {i}");
                continue;
            }
            
            if (i == 1)
            {
                Console.WriteLine($"Goto statement moves back to the beginning of the loop in interaction number {i} incrementing i by 1");
                i++; // Note: i is incremented here so it doesn't enter a infinite loop
                goto JumpHere;
            }
            
            if (i == 6)
            {
                Console.WriteLine($"Break statement will exit the loop in interaction number {i}");
                break;
                // Note: the return statement works similarly to the break but also return the outcome as output
            }
            
            Console.WriteLine($"This is the interaction number {i}");
        }
    }
}