namespace CSharpBasics;

public class Methods
{
    /*
     * Methods are blocks of statements used to perform specific tasks
     * They're basically used to divide large amounts of code into smaller and manageable methods
     *
     * Structure of a method:
     * <access-modifier/specifier> <return-type> functionName(<parameters>)> {
     *      <method/function body>
     *      <return statement>
     * }
     *
     * Optional statements: <access-modifier/specifier>, <parameters>
     *
     * A good practice is to use SOLID method when declaring a method --> always keep minimum functionality inside a function
     * Based on the SOLID method each function should perform only one single functionality
     */

    // Method declaration
    public int Add(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum; // break out the function and return the value as output
    }
    
    // Even or odd method --> Validates if the entered number is even or odd
    // Implement method to print the message based on the output of CheckEvenOrOdd() method
    public void PrintEvenOrOdd()
    {
        // Print the user for input and convert it to integer
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // Call the method CheckEvenOrOdd() and assign the output to a variable
        bool result = CheckEvenOrOdd(number);
        
        // Print the message based on the output of the method
        if (result)
        {
            Console.WriteLine($"Number {number} is even!");
        }
        else
        {
            Console.WriteLine($"Number {number} is odd!");
        }
    }
    
    // Implement method to validate if number is even or odd
    public bool CheckEvenOrOdd(int number)
    {
        return number % 2 == 0;
    }
    
    static void Main(string[] args)
    {
        Methods methods = new Methods(); // to call a method, it's required to initialize the constructor first
        
        // Calling the method Add()
        Console.WriteLine("------------------------------");
        Console.WriteLine("Add method:\n");
        
        int firstSum = methods.Add(10, 20);
        int secondSum = methods.Add(100, 200);
        int thirdSum = methods.Add(15, 55);
        
        // Output
        Console.WriteLine($"First sum: {firstSum}");
        Console.WriteLine($"Second sum: {secondSum}");
        Console.WriteLine($"Third sum: {thirdSum}");
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Even or Odd:\n");
        
        // Calling the method PrintEvenOrOdd()
        methods.PrintEvenOrOdd();
    }
}