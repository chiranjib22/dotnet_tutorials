// when i want a variable to have the same value for all instances of a class, I should use a static variable.
// A static variable is shared among all instances of the class,
// meaning that if one instance changes the value of the static variable, it will be reflected in all other instances.

// static variables gets initialized only once when the class is loaded into memory,
// and they retain their value throughout the lifetime of the application.

// non-static variables initialize each time a new instance of the class is created, and they can have different values for each instance.

// example to understand static and non-static variables in C#
//public class Example
//{
//    int x; // non-static variable
//    static int y = 200; // static variable
//    public Example(int x)
//    { 
//        this.x = x; // non-static variable initialized with the value passed to the constructor
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine($"Static variable y: {Example.y}"); // Accessing static variable without creating an instance of the class
//        Console.WriteLine($"Static variable y: {y}"); // Accessing static variable without class name, since we are in the same class

//        Example obj1 = new Example(10); // Creating an instance of the class and initializing non-static variable x
//        Example obj2 = new Example(20); // Creating another instance of the class and initializing non-static variable x

//        Console.WriteLine($"Non-static variable x of obj1: {obj1.x}"); // Accessing non-static variable x of obj1"
//        Console.WriteLine($"Non-static variable x of obj2: {obj2.x}"); // Accessing non-static variable x of obj2
//    }
//}

// Non-static varibales are created when the object is created and destroyed when the object is destroyed.
// Object is destroyed when its reference variable is destroyed or initialized with null.
// scope of non-static varibale is same as the scope of the object. 

// Static variable scope is the Application scope.
// Static variable is created when the class is loaded into memory and destroyed when the application is closed.

// non-static variables cannot consume directly in static methods,
// if we want to use non-static variables in static methods, we need to create an instance of the class and then access the non-static variable through that instance.

// Static variables can be accessed directly in non-static methods without creating an instance of the class.

// example to understand static and no-static methods in C#

//public class Example
//{
//    int x = 100;
//    static int y = 200;
//    static void Add()
//    {
//        Example obj = new Example();
//        Console.WriteLine($"Sum of 100 and 200 is : {obj.x + y}"); // non-static variable x is accessed at static method through the instance of the class
//        Console.WriteLine($"Sum of 100 and 200 is : {obj.x + Example.y}");
//    }

//    void Mul()
//    {
//        Console.WriteLine($"Multiplication of 100 and 200 is {x * y}");
//        Console.WriteLine($"Multiplication of 100 and 200 is {this.x * Example.y}"); // non-static variable x is accessed at non-static method through the instance of the class
//    }

//    static void Main(string[] args)
//    {
//        Add(); // calling static method without creating an instance of the class
//        Example obj = new Example();
//        obj.Mul(); // calling non-static method through the instance of the class
//    }
//}

// static constructor is going to be executed first without any constructor call
// and that constructor is going to be executed only once in this lifetime. After that the main method is going to be executed
//class Example
//{
//    static Example()
//    {
//        Console.WriteLine("Static Constructor is Called!");
//    }

//    public Example()
//    {
//        Console.WriteLine("Non-static Constructor is Called!");
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Main method execution start");
//        Example obj1 = new Example();
//        Example obj2 = new Example();
//        Console.WriteLine("Main method execution end");
//    }
//}

// static class cannot be instantiated and it can only contain static members.
public static class TemparatureConverter
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

public class  Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select the Convertor option:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Please Enter your option : ");

        int selection = int.TryParse(Console.ReadLine(), out int option) ? option : 0;

        switch(selection)
        {
            case 1:
                Console.Write("Please enter the temperature in Celsius: ");
                double celsius = double.Parse(Console.ReadLine()!);
                double fahrenheit = TemparatureConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                break;
            case 2:
                Console.Write("Please enter the temperature in Fahrenheit: ");
                double fahrenheit2 = double.Parse(Console.ReadLine()!);
                double celsius2 = TemparatureConverter.FahrenheitToCelsius(fahrenheit2);
                Console.WriteLine($"Temperature in Celsius: {celsius2}");
                break;
            default:
                Console.WriteLine("Invalid option selected.");
                break;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

