// 4 types of variables in C#:
// 1. Non static variable (Instance variable) - belongs to an instance of a class
// 2. Static variable (Class variable) - belongs to the class itself
// 3. Constant variable - value cannot be changed after initialization
// 4. Readonly variable - value can be assigned only once, either at declaration or in the constructor

internal class Program
{
    public static int x = 100; // static variable
    public int y = 200; // non static variable

    public Program(int a)
    {
        y = a; // assigning value to non static variable in constructor
    }
    static void Main(string[] args)
    {
        int z; // static variable
        Console.WriteLine($"Static variable x: {x}");
        var obj = new Program(10);
        var obj2 = new Program(20);
        Console.WriteLine($"Non static variable y: {obj.y}");
        Console.WriteLine($"Non static variable y: {obj2.y}");
    }
}
