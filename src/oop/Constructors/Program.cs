// Implicitly constructors are parameter less
// they are public
// also know as Default Constructors

using Constructors;

Test obj = new Test(); // implicit constructor called
Console.WriteLine($"i = {obj.i}");
Console.WriteLine($"b = {obj.b}");

if(obj.s == null)
{
    Console.WriteLine("S = null");
}

Test2 obj2 = new Test2();

// defining constructor maybe implicit or explicit
// calling constructor should be explicit



