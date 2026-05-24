// 4 types of variables in C#:
// 1. Non static variable (Instance variable) - belongs to an instance of a class
// 2. Static variable (Class variable) - belongs to the class itself
// 3. Constant variable - value cannot be changed after initialization
// 4. Readonly variable - value can be assigned only once, either at declaration or in the constructor

internal class Program
{
    public static int x = 100; // static variable
    public int y = 200; // non static variable
    public const float PI = 3.14f; // constant variable 
    public readonly int r = 0; // readonly variable
    public Program(int a,int b)
    {
        y = a; // assigning value to non static variable in constructor
        r = b; // readonly variable can be initialized with constructor
    }
    static void Main(string[] args)
    {
        int z = (int)(PI); // static variable
        Console.WriteLine($"Static variable x: {x}");
        Console.WriteLine($"Constant variable PI: {PI}");
        var obj = new Program(10,5);
        var obj2 = new Program(20,4);
        Console.WriteLine($"Non static variable y: {obj.y}");
        Console.WriteLine($"Non static variable y: {obj2.y}");
        Console.WriteLine($"The readonly varibale z: {obj.r}");
    }
}
