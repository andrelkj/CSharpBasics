namespace CSharpBasics;

public class MultidimensionalArrays
{
      /*
       * Multidimensional Arrays (2D Arrays) - represents an array of arrays
       *
       * To define 2D arrays you need to specify the number of arrays and then the number of items for each internal array
       * Sample 2D array: int[,] matrix2D = new int[2,3] --> [[0, 1, 2], [0, 1, 2]]
       *
       * To assign a value you need to specify the indexes for what array to look into and then the array index itself
       *
       * 3D Arrays - pretty much the same as 2D arrays with the extension of one more layer of arrays
       * Samples 3D array: int[,,] matrix3D = new int[1, 2, 3] --> [[[0, 1, 2], [0, 1, 2], [0, 1, 2]], [[0, 1, 2], [0, 1, 2], [0, 1, 2]]]
       */
      
      static void Main(string[] args)
      {
          Console.WriteLine("------------------------------");
          Console.WriteLine("2D Arrays:");
          // 2D array declaration and initialization
          int[,] matrix2D = new int[3, 3]; // [,] specify that 2 values are expected
          Console.WriteLine(matrix2D);
          
          // 2D array assignment
          matrix2D[0, 0] = 1; // [1, 0, 0]
          matrix2D[1, 1] = 2; // [0, 2, 0]
          matrix2D[2, 2] = 3; // [0, 0, 3]
          
          // 2D array access
          Console.WriteLine("------------------------------");
          Console.WriteLine("Accessing the 2D array indexes:\n");
          
          Console.WriteLine($"First position of the first array is: {matrix2D[0, 0]}");
          Console.WriteLine($"Second position of the first array is: {matrix2D[0, 1]}"); // empty indexes return 0
          Console.WriteLine($"Second position of the second array is: {matrix2D[1, 1]}");
          Console.WriteLine($"Third position of the third array is: {matrix2D[2, 2]}");
          
          Console.WriteLine("------------------------------");
          Console.WriteLine("Getting the length of the arrays:\n");
          
          Console.WriteLine($"Total length of the matrix: {matrix2D.Length}"); // returns the total length of all arrays;
          Console.WriteLine($"Length of the first array: {matrix2D.GetLength(0)}"); // returns the length of the first array;
          Console.WriteLine($"Length of the second array: {matrix2D.GetLength(1)}"); // returns the length of the second array;
          
          // Iterating over 2D arrays
          Console.WriteLine("------------------------------");
          Console.WriteLine("Iterating over 2D arrays:\n");
          
          for (int i = 0; i < matrix2D.GetLength(0); i++)
          {
              for (int j = 0; j < matrix2D.GetLength(1); j++)
              {
                  Console.Write($"[{i}, {j}] = {matrix2D[i, j]} | ");
              }
              
              Console.WriteLine();
          }
          
          Console.WriteLine("------------------------------");
          Console.WriteLine("3D Arrays:");
          
          // 3D array declaration and initialization
          int[,,] matrix3D = new int[2, 2, 2]; // [,,] specify that 3 values are expected
          Console.WriteLine(matrix3D);
          
          // 3D array assignment
          matrix3D[0, 0, 0] = 1; // [1, 0, 0]
          matrix3D[0, 0, 1] = 2; // [1, 2, 0]
          matrix3D[0, 1, 0] = 3; // [0, 0, 3]
          
          // 3D array access
          Console.WriteLine("------------------------------");
          Console.WriteLine("Accessing the 3D array indexes:\n");
          Console.WriteLine($"First position of the first array of the first array is: {matrix3D[0, 0, 0]}");
          Console.WriteLine($"Second position of the first array of the first array is: {matrix3D[0, 0, 1]}");
          Console.WriteLine($"First position of the second array of the first array is: {matrix3D[0, 1, 0]}");
          Console.WriteLine($"First position of the first array of the second array is: {matrix3D[1, 0, 0]}"); // empty indexes return 0
          
          Console.WriteLine("------------------------------");
          Console.WriteLine("Getting the length of the arrays:\n");
          Console.WriteLine($"Total length of the matrix: {matrix3D.Length}"); // returns the total length of all arrays;
          Console.WriteLine($"Length of the first array: {matrix3D.GetLength(0)}"); // returns the length of the first array;
          Console.WriteLine($"Length of the second array: {matrix3D.GetLength(1)}"); // returns the length of the second array;
          Console.WriteLine($"Length of the third array: {matrix3D.GetLength(2)}"); // returns the length of the third array;
          
          // Iterating over 3D arrays
          Console.WriteLine("------------------------------");
          Console.WriteLine("Iterating over 3D arrays:\n");

          for (int i = 0; i < matrix3D.GetLength(0); i++) // iterate over the first layer of arrays
          {
              for (int j = 0; j < matrix3D.GetLength(1); j++) // iterate over the second layer of arrays 
              {
                  for (int k = 0; k < matrix3D.GetLength(2); k++) // iterate over the third layer of arrays (actual values)
                  {
                      Console.Write($"[{i}, {j}, {k}] = {matrix3D[i, j, k]} | "); // writes all on the same line
                  }
                  
                  Console.WriteLine();
              }
          }
      }
}