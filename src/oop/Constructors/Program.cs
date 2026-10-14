// Implicitly constructors are parameter less
// they are public
// also know as Default Constructors

//using Constructors;

//Test obj = new Test(); // implicit constructor called
//Console.WriteLine($"i = {obj.i}");
//Console.WriteLine($"b = {obj.b}");

//if(obj.s == null)
//{
//    Console.WriteLine("S = null");
//}

//Test2 obj2 = new Test2();

// defining constructor maybe implicit or explicit
// calling constructor should be explicit

// system defined default constructor(parameterless)
// user defined default constructor(parameterless)
using Constructors;

Employee e1 = new Employee();
Console.WriteLine("Employee Id is: " + e1.Id);
Console.WriteLine("Employee Name is: " + e1.Name);
Console.WriteLine("Employee Age is: " + e1.Age);
Console.WriteLine("Employee Address is: " + e1.Address);
Console.WriteLine("Is Employee Permanent: " + e1.IsPermanent);


// parameterized constructor (parameterized)
ParameterizedConstructor p1 = new ParameterizedConstructor(10);

// copy constructor
CopyConstructor obj1 = new CopyConstructor(20);
obj1.Display();
CopyConstructor obj2 = new CopyConstructor(obj1);
obj2.Display();

// IN one class there are 1 (no argument constructor) and n number of parameterized constructor


// static constructor are responsible for defining static variables
StaticConstructor.Display();

StaticConstructor s1 = new StaticConstructor();

// private constructor
//PrivateConstructor p1 = new PrivateConstructor(); // cannot be called outside of the class


