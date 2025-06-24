namespace CSharpBasics.Collections;

public class ExceptionHandling
{
    /*
     * Exception Handling
     *
     * 1. Try - block of code that is going to be executed and can cause exceptions.
     * 2. Catch - block of code that will handle the exception, executed only if there is an exception.
     * 3. Finally - a block of code executed that is always executed regardless of having or not exceptions.
     * 4. Throw - statement used to intentionally throw exceptions.
     *
     * Note: if unhandled exceptions are triggered, a generic exception error will be thrown.
     *
     * It is possible to throw and catch specific exceptions (e.g., IndexOutOfRangeException), just note that in this case there might be unhandled exceptions.
     * Once an exception is thrown the try block exits, code that comes after the exception is not executed.
     */

    static void Main(string[] args)
    {
        try
        {
            // Try a block of code that can throw exceptions
            int[] a = [10, 20, 30];
            // Console.WriteLine(a[3]); // Triggers the exception --> Index was outside the bounds of the array.

            throw new IndexOutOfRangeException("Specific exception message"); // Triggers a intentional exception
            throw new Exception("Intentional exception message"); // Triggers a intentional exception
        }
        catch (IndexOutOfRangeException e)
        {
            // Catch specific exceptions
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            // Catch any exception
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Finally block of code that is always executed regardless of having or not exceptions
            Console.WriteLine("Finally block of code is always executed");
        }
    }
}