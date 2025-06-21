namespace CSharpBasics.Basics;

public class Strings
{
    /*
     * string itself is a keywork to define a data type which stores a combination os characters, String defines a class
     * string concatenation
     * operators
     * basic control flow statements (if-else, loops, etc.)
     */
    
    static void Main(string[] args)
    {
        // strings
        string s = "Hello";
        Console.WriteLine(s);

        String S = "Hi";
        Console.WriteLine(S);
        
        String S2 = new String("Olá");
        Console.WriteLine(S2);
        
        
        // string concatenation
        string s1 = "Hello";
        string s2 = "World";
        
        // the expected output --> Hello World
        // + operator --> Binary Operator --> requires 2 operands to perform the operation (addition of numbers or concatenation of strings)
        int addition = 1 + 2;
        Console.WriteLine($"Numbers addition: {addition}");
        
        string concatenation = s1 + " " + s2;
        Console.WriteLine($"Strings concatenation: {concatenation}");
        
        // Note: sum between a number and a string converts the number into a string
        var numberConcatenation = 1 + 2 + "word"; // 1 + 2 are added to each other and then converted to string --> 3word
        Console.WriteLine($"Number concatenation: {numberConcatenation}");
        Console.WriteLine("test" + 1 + 2); // operation is executed from left to right so no number is added --> test12
    }
}