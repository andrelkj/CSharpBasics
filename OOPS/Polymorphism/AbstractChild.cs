namespace CSharpBasics.OOPS.Polymorphism;

public abstract class AbstractChild : Polymorphism // an abstract tag is added since it is a child of an abstract class
{
        // Abstract method declared inside the parent class now requires an override since it isn't defined yet
        public override void AbstractMethod()
        {
                Console.WriteLine("This is the overriden abstract method defined in the parent class.");
        }
        
        void Main(string[] args) // static tag is removed since we cannot instantiate abstract methods
        {
                AbstractMethod();
        }
}