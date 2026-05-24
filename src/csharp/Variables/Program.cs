// 4 types of variables in C#:
// 1. Non static variable (Instance variable) - belongs to an instance of a class
// 2. Static variable (Class variable) - belongs to the class itself
// 3. Constant variable - value cannot be changed after initialization
// 4. Readonly variable - value can be assigned only once, either at declaration or in the constructor

internal class Program
{
    public static int x = 100; // static variable
    public int y; // non static variable
    public const float PI = 3.14f; // constant variable, behaviour same as static variable

    // difference is that constant variable must be initialized at the time of declaration and cannot be changed later,
    // whereas static variable can be assigned a value at any time and can be changed later

    public readonly int r = 10; // readonly variab

    public Program(int a,int r)
    {
        y = a; // assigning value to non static variable in constructor
        this.r = r; // assigning value to readonly variable in constructor
    }
    static void Main(string[] args)
    {
        int z = (int)(PI); // static variable
        Console.WriteLine($"Static variable x: {x}");
        Console.WriteLine($"Constant variable PI: {PI}");
        var obj = new Program(10,30);
        var obj2 = new Program(20,40);
        Console.WriteLine($"Non static variable y: {obj.y}");
        Console.WriteLine($"Readonly variable r: {obj.r}");
        Console.WriteLine($"Non static variable y: {obj2.y}");
        Console.WriteLine($"Readonly variable r: {obj2.r}");
        obj.Method();
    }

    private void Method()
    {
        int localVariable; // local variable, only accessible within this method
        localVariable = 10;
        Console.WriteLine($"Local variable: {localVariable}");
    }
}
