namespace CSharpBasics.Basics;

public class Arrays
{
      /*
       * Arrays - a data structure that stores a sequence of similar datatypes
       * Each value of an array is known as an array element referenced by an integer number known as array index
       *
       * Total number of elements in an array defines it's length that starts from index 0
       * Sample array: [0, 1, 2, 3] - array length = 4
       *
       * There can be 1, 2 or 3 dimension arrays
       * To define an array you need to specify its elements type and length --> new int[3], new string[5]
       * Once defined you can assign the new array to a variable --> int[] array = new int[3]
       */
      
      static void Main(string[] args)
      {
          // Array declaration and initialization
          int[] numbers = new int[3]; // creates an integer array of length 3 and assign it to the numbers variable
          string[] names = new string[4]; // creates a string array of length 4 and assign it to the names variable
          int[] assignment = [1, 2, 3, 4, 5]; // creates an array of length 5 and initialize a variable with assigned values
          // Note: creating arrays with assigned values is discouraged unless you really need hardcoded values
          
          Console.WriteLine("------------------------------");
          
          // Array assignment
          names[0] = "André";
          names[1] = "Bárbara";
          names[2] = "Ayumi";
          names[3] = "Seiji";
          
          // Return values from an array
          Console.WriteLine("Returning values from the array:");
          
          Console.WriteLine(numbers.Length); // returns the length of the array;
          Console.WriteLine(assignment.Length);
          Console.WriteLine(names); // in C# calling the array element will display the element itself not it's content
          
          Console.WriteLine(names[0]);
          Console.WriteLine($"{names[0]}, {names[1]}...");
          Console.WriteLine(string.Join(", ", names)); 
          
          Console.WriteLine("------------------------------");
          
          // Array iteration
          Console.WriteLine("Iterating through the array:");

          numbers = [0, 1, 2, 3, 4, 5];
          
          Console.WriteLine("------------------------------");
          
          // Basic interaction using for method
          Console.WriteLine("Iteration over arrays using for loop:");
          for (int i = 0; i < numbers.Length; i++)
          {
              Console.WriteLine($"Iteration number {i + 1}: {numbers[i]}");
          }
          
          Console.WriteLine("------------------------------");
          
          // Same iteration but using foreach method
          Console.WriteLine("Iteration over arrays using foreach loop:");
          foreach (int number in numbers)
          {
              Console.WriteLine($"Iteration number {numbers.Length}: {number}");
          }
          // Note: foreach method has downsides since it cannot be reversed, for example
          
          Console.WriteLine("------------------------------");
          
          // Reverting the order of an array
          Console.WriteLine("Reverting the order of an array:");
          for (int i = numbers.Length - 1; i >= 0; i--)
          {
              Console.WriteLine(numbers[i]);
          }
      }
}