namespace CSharpBasics.OOPS.Polymorphism;

/*
 * Interface - used to declare abstract methods that won't be defined yet
 * Although interfaces allow declaring defined methods. This is rarely used since abstract methods can do it better by including non-abstract method calls altogether
 *
 * Multiple inheritance is possible in interfaces once the same method can be declared in different interfaces, but only defined once inside the actual class
 * It is not possible to instantiate an interface, but similar to abstract classes you can refer to child class methods
 */

public interface IInterface
{
    void InterfaceMethod(); // same method defined in different interfaces
    static int X = 10;
}

public interface IInterface2
{
    void InterfaceMethod(); // same method defined in different interfaces
    void SecondInterfaceMethod();
}