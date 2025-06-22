namespace CSharpBasics.Basics;

public class AccessModifiers
{
    /*
     * Access modifiers - specifies the level permission which class, method or variable will have to avoid unintended access.
     * 1. public - accessible anywhere from its declaration project and others
     * 2. private - accessible inside its declaration class only
     * 3. protected - accessible inside its declaration class and its child classes
     * 4. internal - accessible anywhere inside the project but only inside the project where it was declared
     * 
     * Important note: while variables and methods can use all the types above and others, classes can only be of public or internal types
     */

    public class MainClass
    {
        // Access modifiers:
        public string publicVariable = "This is a public variable";
        private string privateVariable = "This is a private variable";
        protected string protectedVariable = "This is a protected variable";
        internal string internalVariable = "This is a internal variable";
        string defaultVariable = "This is a variable without specified access modifier (receives private as default)";

        void DefaultMethod()
        {
            Console.WriteLine("This a method without specified access modifier (receives private as default)");
        }

        public void PublicMethod()
        {
            Console.WriteLine("This is a public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method");
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers:");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Using access modifiers within it's declaration method:");
            Console.WriteLine("------------------------------");
            
            MainClass mainClass = new MainClass();

            // Variables:
            Console.WriteLine("Variables:\n");
            
            Console.WriteLine($"Public: {mainClass.publicVariable}");
            Console.WriteLine($"Private: {mainClass.privateVariable}");
            Console.WriteLine($"Protected: {mainClass.protectedVariable}");
            Console.WriteLine($"Internal: {mainClass.internalVariable}");
            Console.WriteLine($"Default: {mainClass.defaultVariable}");

            Console.WriteLine("------------------------------");

            // Methods:
            Console.WriteLine("Methods:\n");
            
            mainClass.PublicMethod();
            mainClass.PrivateMethod();
            mainClass.ProtectedMethod();
            mainClass.InternalMethod();
            mainClass.DefaultMethod();

            Console.WriteLine("------------------------------");
        }
    }

    public class ChildClass : MainClass
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Access Modifiers:");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Using access modifiers inside of child classes:");
            Console.WriteLine("------------------------------");
            
            ChildClass childClass = new ChildClass();

            // Variables:
            Console.WriteLine("Variables:\n");
            
            Console.WriteLine($"Public: {childClass.publicVariable}");
            // Console.WriteLine($"Private: {childClass.privateVariable}"); // returns an error since private variables are only available inside their declaration class
            Console.WriteLine($"Protected: {childClass.protectedVariable}");
            Console.WriteLine($"Internal: {childClass.internalVariable}");
            // Console.WriteLine($"Default: {childClass.defaultVariable}"); // since variables without an access modifier specified are defined as private it behaves same as private variables

            Console.WriteLine("------------------------------");

            // Methods:
            Console.WriteLine("Methods:\n");
            
            childClass.PublicMethod();
            // childClass.PrivateMethod(); // returns an error since private methods are only available inside their declaration class
            childClass.ProtectedMethod();
            childClass.InternalMethod();
            // childClass.DefaultMethod(); // since default methods are defined as private it behaves same as private methods
            
            Console.WriteLine("------------------------------");
        }
    }
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Access Modifiers:");
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Using access modifiers from external classes:");
        Console.WriteLine("------------------------------");
            
        MainClass mainClass = new MainClass();

        // Variables:
        Console.WriteLine("Variables:\n");
            
        Console.WriteLine($"Public: {mainClass.publicVariable}");
        // Console.WriteLine($"Private: {mainClass.privateVariable}"); // returns an error since private variables are only available inside their declaration class
        // Console.WriteLine($"Protected: {mainClass.protectedVariable}"); // returns an error since protected variables are only available inside their declaration class or its child classes
        Console.WriteLine($"Internal: {mainClass.internalVariable}");
        // Console.WriteLine($"Default: {mainClass.defaultVariable}"); // since default variables are defined as private it behaves same as private methods

        Console.WriteLine("------------------------------");

        // Methods:
        Console.WriteLine("Methods:\n");
            
        mainClass.PublicMethod();
        // mainClass.PrivateMethod(); // returns an error since private methods are only available inside their declaration class
        // mainClass.ProtectedMethod(); // returns an error since protected methods are only available inside their declaration class or its child classes
        mainClass.InternalMethod();
        // mainClass.DefaultMethod(); // since default methods are defined as private it behaves same as private methods

        Console.WriteLine("------------------------------");
    }
}