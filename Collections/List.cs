namespace CSharpBasics.Collections;

public class List
{
    /*
     * System.Collections (deprecated) - List, HashSet, Dict
     * System.Collections.Generic namespaces
     *  
     * 1. Generic - classes can store one type of value only. While creating the object its type can be specified with angular brackets <>
     * 2. Non-generic - classes can store any type of values --> deprecated method
     */

    static void Main(string[] args)
    {
        List<string> list = new List<string>(); // List<string> is a generic class
        list.Add("First value of the list");
        list.Add("Second value of the list");
        // list.Add(10); // returns a error since the list only accept strings
        
        // List methods
        Console.WriteLine("List methods:");
        Console.WriteLine($"Count returns the size of the list: {list.Count}");
        
        Console.WriteLine("------------------------------");
        
        // Manipulate lists
        Console.WriteLine("Access list values:");
        Console.WriteLine($"Accessing the first index value of the list - list[0]: {list[0]}");
        
        Console.WriteLine("------------------------------");
        
        // Iterating over lists
        Console.WriteLine("Iterating over lists:");
        
        // For each method - preferable since it will already consider the list length
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        
        // For loop method - alternative whenever you need to reverse the order
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}