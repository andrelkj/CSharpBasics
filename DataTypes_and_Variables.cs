using System.Diagnostics;

Console.WriteLine("Basics of C# - Data Types and Variables");
// -------------------------------------------------------------------------------------------------------------------------------------------------------

/*
 * Data Types and Variables
 * There are 4 types of Data Types in C#
 *
 * 1. Reference Types: class, interface, string, array, delegates, etc.
 * 2. Value Types or Built-in Types: int, long, float, double, char, boolean, etc.
 * 3. Pointer Types: *,&
 * 4. Nullable Types: Nullable types in C# are types that allow variables to receive a value or null
*/
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Value Types:

// Numbers
int validInteger = 30; // 4 byte memory ---> 1 byte equals 8 bit --. 32-bits memory allocated starting from -2,147,483,648 up to 2,147,483,647
Console.WriteLine($"Integer: + {validInteger}");
// Debug.WriteLine(validInteger);

// int overMemoryPositiveInt = 2147483648; // the error is thrown since the value is over integer memory capacity
// int overMemoryNegativeInt = -2147483649; // the error is thrown since the value is over integer memory capacity

// Console.WriteLine(overMemoryPositiveInt);
// Console.WriteLine(overMemoryNegativeInt);

short validShortInteger = 100; // 2 byte memory --> represent 16-bits of memory allocated for a single small numbers
Console.WriteLine($"Short: {validShortInteger}");

long validLongInteger = 21474836481239L; // 8 byte memory --> represent 64-bits of memory allocated which can store larger integer numbers only
Console.WriteLine($"Long: {validLongInteger}");

float validFloat = 30.0f; // 4 byte memory --> represent 32-bits of memory allocated, similar to int but including decimals
Console.WriteLine($"Float: {validFloat}");

double validDouble = 30.01234d; // 8 byte memory --> represent 64-bits of memory allocated, similar to long but including decimals
Console.WriteLine($"Double: {validDouble}");

// Positive only - it is possible to specify memory allocated for positive numbers only for each value type simply by adding u prefix before the value type
uint validUnit = 123; // 4 byte memory --> represent 32-bits of memory allocated for positive numbers only
Console.WriteLine($"Positive integer: {validUnit}");

ulong validULong = 123456789; // 8 byte memory --> represent 64-bits of memory allocated for positive numbers only
Console.WriteLine($"Positive long: {validULong}");

// ushort invalidUShort = -12; // the error is thrown since the value is negative
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Text
char validChar = 'a'; // 2 byte memory --> represent 16-bits of memory allocated for a single character only
Console.WriteLine($"Char: {validChar}");

string validString = "Hello World"; // 24 bytes memory --> represent 16-bits of memory allocated for longer texts
Console.WriteLine($"String: {validString}");
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Booleans
bool validBoolean = true; // 1 byte memory --> represent 8-bits of memory allocated for true or false
Console.WriteLine($"Boolean: {validBoolean}");
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Bytes
byte validByte = 123; // 1 byte memory --> represent 8-bits of memory allocated starting from 0 up to 255
Console.WriteLine($"Byte: {validByte}");

// byte invalidByte = 256 // the error is thrown since the value is over byte memory capacity
// Console.WriteLine(invalidByte);

sbyte validSByte = -123; // 1 byte memory --> represent 8-bits of memory allocated starting from -128 up to 127
Console.WriteLine($"Negative byte: {validSByte}");
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Special
var validVar = "Hello World"; // 24 bytes memory --> represent 16-bits of memory allocated for longer texts
Console.WriteLine($"Var: {validVar}");
// Debug.WriteLine($"Var: {validVar}");

// Note: once a data type is defined for the var you cannot assign a different data type value to the same var
// validVar = 123; // the error is thrown since the value is not a string

dynamic validDynamic = "Hello World"; // 24 bytes memory --> represent 16-bits of memory allocated for variables with dynamic data types
Console.WriteLine($"Dynamic initial value: {validDynamic}");

validDynamic = 123; // variable initialized as string, now switch to receive numeric values
Console.WriteLine($"Dynamic changed value: {validDynamic}");

string name = "André";
int age = 27;
// -------------------------------------------------------------------------------------------------------------------------------------------------------

// Input and Output
Console.WriteLine("Hello {0}, you are {1} years old.", name, age); // string format with argument inputs
Console.WriteLine("Hello " + name + ", you are " + age + " years old."); // string concatenation
Console.WriteLine($"Hello {name}, you are {age} years old."); // string format with fixed variable params

Console.WriteLine("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your age is: {userAge}");
// -------------------------------------------------------------------------------------------------------------------------------------------------------