namespace CSharpBasics.Basics;

public class ControlFlowStatements
{
    static void Main(string[] args)
    {
        /*
         * if - if else, switch case - controls the flow state based on specific conditions guide the flow to one side or another (true or false)
         * loops - for, forEach, while, do while - allow executing blocks of code repeatably until specific conditions are fulfilled
         */
        
        Random random = new Random();
        int number = random.Next(1, 10);
        Console.WriteLine($"Number: {number}");
        
        Console.WriteLine("------------------------------");

        // If, If-Else, If-Elseif-Else statements - use if whenever you focus on behaviors for true or false conditions
        Console.WriteLine("If else statement:");

        if (number > 5)
        {
            Console.WriteLine("Number is greater than 5!");
        } else if (number == 5)
        {
            Console.WriteLine("Number is equal to 5!");
        } else {
            Console.WriteLine("Number is smaller than 5!");
        }
        
        Console.WriteLine("------------------------------");
        
        // Switch case statements - use switch whenever you focus on behaviors depending on specific values (numbers, string, etc.)
        Console.WriteLine("Switch case statement:");
        
        switch (number)
        {
            case 0:
                Console.WriteLine("Number is 0!");
                break;
            case 1:
                Console.WriteLine("Number is 1!");
                break;
            case 2:
                Console.WriteLine("Number is 2!");
                break;
            default:
                Console.WriteLine("Number is neither 1 or 2!");
                break;
        }
        
        Console.WriteLine("------------------------------");
        
        // Loops
        Console.WriteLine("Loops:");

        // While loop - repeats a block of code until the condition is fulfilled - use while whenever you need to repeat the code for a UNKNOWN number of times
        Console.Write("While loop:\n");
        
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine($"{count} is smaller than 3!");
            count++;
        }
        
        Console.WriteLine("------------------------------");
        
        // Do While loop - runs the code at least once before entering the loop and then repeats it until fulfillment - use do while whenever you need to perform an action before the loop
        Console.Write("Do While loop:\n");

        int input;
        do
        {
            Console.WriteLine($"Enter a number guess from 0 to 10");
            input = Convert.ToInt32(Console.ReadLine());
            
            if (input is < 0 or > 10)
            {
                Console.WriteLine("This is not a valid input!");
            } else if (input > number)
            {
                Console.WriteLine("Number is too high! Try again.");
            } else if (input < number)
            {
                Console.WriteLine("Number is too low! Try again.");
            } else {
                Console.WriteLine("Congratulations, you guessed it right!");
            }
        } while (input != number);
        
        Console.WriteLine("------------------------------");
        
        // For loop - repeats a block of code a specific number of times - use for whenever you need to repeat the code for a KNOWN number of times
        Console.Write("For loop:\n");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i} is smaller than 3!");
        }
        
        Console.WriteLine("------------------------------");
        
        // Nested loops - allow running loops inside another loop, in this case the outer loop is only executed once the inner loop condition is met
        Console.Write("Nested loops:\n");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Outer loop was executed {i+1} time(s).");
            
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"This is inner loop's  {j+1}° execution.");
            }
        }
        // Note: in this example the total number of interactions will be 6 since the inner loop will run 3 times plus 3 times for the outer loop. Also note that the index starts from 0.
    }
}