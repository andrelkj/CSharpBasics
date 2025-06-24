namespace CSharpBasics.Collections;

public class Dictionary
{
    /*
     * Dictionary - unordered collection of key-value pairs
     */
    
    static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        
        // Dictionary methods:
        Console.WriteLine("Adding elements to the Dictionary:");
        dictionary.Add(1, "First value");
        dictionary.Add(2, "Second value");
        dictionary.Add(3, "Third value");
        
        // Output
        Console.WriteLine($"First value of the dictionary: {dictionary[1]}");

        Console.WriteLine("------------------------------");
        
        Console.WriteLine("Removing elements from the Dictionary:");
        dictionary.Remove(2);
        
        // Checking for keys in the dictionary
        Console.WriteLine($"Checking for keys not in the dictionary: {dictionary.ContainsKey(2)}");
        Console.WriteLine($"Checking for keys in the dictionary: {dictionary.ContainsKey(3)}");
        
        // Checking for values in the dictionary
        Console.WriteLine($"Checking for values not in the dictionary: {dictionary.ContainsValue("Second value")}");
        Console.WriteLine($"Checking for values in the dictionary: {dictionary.ContainsValue("Third value")}");
        
        Console.WriteLine("------------------------------");
        
        // Iterating over dictionaries
        Console.WriteLine("Iterating over dictionaries:");
        
        // For each method - preferable since it will already consider the dictionary length
        foreach (var item in dictionary)
        {
            Console.WriteLine(item); // print each key-value pair as an array
            Console.WriteLine(item.Key); // print each key
            Console.WriteLine(item.Value); // print each value
            
            Console.WriteLine("------------------------------");
        }
    }
}