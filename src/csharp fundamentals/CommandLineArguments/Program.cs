
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"First command line argument: {args[0]}");
        Console.WriteLine($"Second Commad line argument: {args[1]}");
        Console.WriteLine($"Third Command line argument: {args[2]}");
    }

}

// Importance of command line arguments in C#
// 1. Captured into string array called args in Main method.
// 2. Used to specify configuration information while lunching the application.(runtime)
