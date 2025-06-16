namespace CSharpBasics;

public class Operators
{
    static void Main(string[] args)
    {
        // Operators --> arithmetic, relation, conditional, unary
        // Arithmetic operators --> binary operators ( +, -, *, /, %)

        int i = 10;
        int j = 20;
        
        Console.WriteLine($"Addition: {i + j}"); // addition
        Console.WriteLine($"Subtraction: {i - j}"); // subtraction
        Console.WriteLine($"Multiplication: {i * j}"); // multiplication
        Console.WriteLine($"Division: {i / j}"); // division - returns 0 since j is defined as an integer and the result is a decimal value (0.5)
        Console.WriteLine($"Module: {i % 3}"); // module - return the remainder of the division between the value on the right and the value on the left
        
        // Note: whenever an operation happens between different data types, the higher precedence is applied to the output
        double x = 30;
        Console.WriteLine(i / x); // returns a double value since x (of type double) has higher precedence
        
        /*bool a = true;
        bool b = false;
        Console.WriteLine(a + b); // returns a error since boolean values cannot be concatenated*/
    }
}