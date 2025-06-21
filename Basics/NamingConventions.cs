namespace CSharpBasics.Basics;

/*
 * Naming Conventions
 *
 * Camel case (camelCase): used to define local variables and method parameters
 * Pascal case (PascalCase): used to define public members like Class names, method names, constants and properties
 * Underscore prefix (_underscorePrefix): commonly used to define private fields
 * Interface names (IInterfaceNames): typically starts with the letter I followed by PascalCase
 */

// Interface example starting with I
public interface IVehicle
{
    void Start();
    void Stop();
}

public class NamingConventions
{
    // Private fields with underscore prefix
    private readonly string _firstName;
    private readonly int _totalCount;
    private readonly bool _isActive;

    // Public properties using PascalCase
    public string FullName { get; set; }
    public int AccountNumber { get; set; }
    public bool IsEnabled { get; set; }

    // Constants using PascalCase
    public const string DefaultMessage = "Hello";
    public const int MaxAttempts = 3;

    static void Main(string[] args)
    {
        // Local variables using camelCase
        string firstName = "John";
        int userAge = 25;
        bool isValid = true;
        
        // Method parameters are also camelCase (see below in CalculateTotal method)
        
        // Creating an instance using PascalCase for class name
        NamingConventions namingDemo = new NamingConventions();
        
        // Calling method with camelCase parameter
        namingDemo.CalculateTotal(basePrice: 100, taxRate: 0.2);
    }

    // Method name in PascalCase, parameters in camelCase
    public double CalculateTotal(double basePrice, double taxRate)
    {
        // Local variable in camelCase
        double finalPrice = basePrice * (1 + taxRate);
        return finalPrice;
    }
}

/*
    1. : **Camel case (camelCase)**
    - Local variables: `firstName`, `userAge`, `isValid`, `finalPrice`
    - Method parameters: `basePrice`, `taxRate`

    2. : **Pascal case (PascalCase)**
    - Class name: `NamingConventions`
    - Method names: `CalculateTotal`
    - Properties: `FullName`, `AccountNumber`, `IsEnabled`
    - Constants: `DefaultMessage`, `MaxAttempts`

    3. : **Underscore prefix (_underscorePrefix)**
    - Private fields: `_firstName`, `_totalCount`, `_isActive`

    4. : **Interface names (IInterfaceNames)**
    - Interface: `IVehicle`
*/
