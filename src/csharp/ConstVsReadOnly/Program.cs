// constants variables are immutable and known at the compile time.
// readonly variables are immutable and known at the runtime.

// const variables can't be modified after the declaration, so it is mendatory to initialize them at the time of declaration.
// If we don't initialize the const variable at the time of declaration, we will get a compile time error.
// const variables are static by default, means it is created one and only one time.

//class Program
//{
//    const float PI = 3.14f; // const variable initialized at the time of declaration
//    static void Main(string[] args)
//    {
//        Console.WriteLine(Program.PI); // accessing const variable using class name
//        Console.WriteLine(PI); // accessing const variable directly

//        const int NUMBER = 100; // const variable within a function
//        Console.WriteLine(NUMBER); // accessing const variable within a function

//        //NUMBER = 20; // compile time error, const variable can't be modified after the declaration
//    }
//}

// the only difference between static and const variables is that static variables can be modified after the declaration,
// but const variables can't be modified after the declaration.


// It is not mandatory to initialize the readonly variable at the time of declaration.
// readonly variables can be initialized at the time of declaration or in the constructor of the class later.
// readonly variables are not static by default, means it is created each time a new instance of the class is created.

//public class Program
//{
//    readonly int x; // default value of readonly variable is 0
//    static void Main(string[] args)
//    {
//        Program obj1 = new Program(); 
//        Console.WriteLine($"{obj1.x}"); // accessing readonly variable using object of the class
//    }
//}

//public class Program
//{
//    readonly int number = 5; // readonly variable initialized at the time of declaration
    
//    // but it is allowed to change the value of readonly variable in the constructor of the class
//    public Program(int num)
//    {
//        number = num; // readonly variable initialized in the constructor of the class means known at the runtime
//    }

//    static void Main(string[] args)
//    {
//        Program obj1 = new Program(10);
//        Console.WriteLine($"{obj1.number}"); // accessing readonly variable using object of the class
//        //obj1.number = 20; // compile time error, readonly variable can't be modified after the declaration

//        // readonly variable are created once per instance.
//        Program obj2 = new Program(20);
//        Console.WriteLine($"{obj2.number}"); // here readonly variable is created again for the new instance of the class and initialized with the value 20

//    }
//}

// difference between const and readonly variables is const contains fixed value for whole class, 
// but readonly is a fixed value for each specific instances of a class

public class Program
{
    const float PI = 3.14f; // const variable
    static int x = 100; // static variable
    int y; // non-static variable
    readonly int z; // readonly variable

    public Program(int a, int b)
    {
        y = a; // non-static variable initialized in the constructor of the class
        z = b; // readonly variable initialized in the constructor of the class
    }

    static void Main(string[] args)
    {
        Program obj1 = new Program(10, 20);
        Console.WriteLine($"Const variable PI: {PI}"); // accessing const variable 
        Console.WriteLine($"Static variable x: {x}"); // accessing static variable 
        Console.WriteLine($"Non-static variable y of obj1: {obj1.y}"); // accessing non-static variable using object of the class
        Console.WriteLine($"Readonly variable z of obj1: {obj1.z}"); // accessing readonly variable using object of the class
        Program obj2 = new Program(30, 40);
        Console.WriteLine($"Non-static variable y of obj2: {obj2.y}"); // accessing non-static variable using object of the class
        Console.WriteLine($"Readonly variable z of obj2: {obj2.z}"); // accessing readonly variable using object of the class
    }
}