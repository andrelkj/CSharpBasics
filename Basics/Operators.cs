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

        Console.WriteLine("------------------------------");
        
        /*
         * Comparisson operator | Equality | Relational operator
         * == Equal to
         * != Not Equal to
         * > Greater than
         * < Less than
         * >= Greater than or equal to
         * <= Less than or equal to
         */

        int a = 5;
        int b = 10;
        
        Console.WriteLine(a == b); // false
        Console.WriteLine(a != b); // true
        Console.WriteLine(a > b); // false
        Console.WriteLine(a < b); // true
        Console.WriteLine(a >= b); // false
        Console.WriteLine(a <= b); // true
        
        Console.WriteLine("------------------------------");
        
        /*
         * Logical | Conditional operators
         * && (Logical AND) - returns true if both conditions are true
         * || (Logical OR) - returns true if any of the conditions are true
         * ! (Logical NOT) - invert the value (!true expect not to be true, !false expect not to be false)
         */
        
        bool condition1 = true;
        bool condition2 = false;
        
        Console.WriteLine(condition1 && condition2); // false
        Console.WriteLine(condition1 || condition2); // true
        Console.WriteLine(!condition1); // false
        
        Console.WriteLine("------------------------------");
        
        /*
         * Assignment operators
         * = Simple assignment
         * += Add and assign
         * -= Subtract and assign
         * *= Multiply and assign
         * /= Divide and assign
         *  %= Modulus and assign
         */

        int num = 10;
        Console.WriteLine($"Simple assignment: {num}"); // 10
        
        num += 10;
        Console.WriteLine($"Add and assign: {num}"); // 20
        
        num -= 15;
        Console.WriteLine($"Subtract and assign: {num}"); // 5
        
        num *= 2;
        Console.WriteLine($"Multiply and assign: {num}"); // 10
        
        num /= 2;
        Console.WriteLine($"Divide and assign: {num}"); // 5
        
        num %= 2;
        Console.WriteLine($"Modulus and assign: {num}"); // 1
        
        Console.WriteLine("------------------------------");
        
        /*
         * Increment and Decrement operators
         * Usually found as prefix or postfix and represented by a ++ (increment) or -- (decrement)
         */
    
        // Prefix increment (++var)
        int value1 = 10;
        int prefixIncrement = ++value1; // value1 is incremented first and then the value is assigned to prefixIncrement
        Console.WriteLine($"Prefix increment: {prefixIncrement}"); // 11

        // Postfix increment (var++)
        value1 = 10;
        int postIncrement = value1++; // value1 is assigned to the variable first and then the value is incremented
        Console.WriteLine($"Post increment: {postIncrement}"); // 10
        Console.WriteLine($"Incremented value: {value1}");

        // Prefix decrement (--var)
        value1 = 10;
        int prefixDecrement = --value1; // value1 is decremented first and then the value is assigned to prefixDecrement
        Console.WriteLine($"Prefix decrement: {prefixDecrement}"); // 9
        
        // Postfix decrement (var--)
        value1 = 10;
        int postDecrement = value1--; // value1 is assigned to the variable first and then the value is decremented
        Console.WriteLine($"Post decrement: {postDecrement}"); // 10
        Console.WriteLine($"Decremented value: {value1}");
    }
}