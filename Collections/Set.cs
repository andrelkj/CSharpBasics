namespace CSharpBasics.Collections;

public class Set
{
    /*
     * HashSet - unordered collection of unique elements
     *
     * Note: because hashset is not ordered it is not possible to access elements by index, although it is still possible to iterate with foreach method
     */
    
    static void Main(string[] args)
    {
        HashSet<int> hashSet = new HashSet<int>();
        
        // HashSet methods:
        Console.WriteLine("Adding elements to the HashSet:");
        hashSet.Add(10);
        hashSet.Add(10);
        hashSet.Add(10);

        Console.WriteLine($"Since the HashSet only accepts unique values, the size is: {hashSet.Count}");
        
        hashSet.Add(100);
        Console.WriteLine($"But by adding different values the size now increases to: {hashSet.Count}");
        
        Console.WriteLine("------------------------------");

        Console.WriteLine("Values in the HashSet:");
        // Iterating over hashSets
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
    }
}