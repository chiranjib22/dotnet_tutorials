//int i = 10; // value types means they are struct types and are stored in the stack memory. They are copied by value.
//double d = 20.5;

//string str = ""; // reference types means they are class types and are stored in the heap memory. They are copied by reference.

//// difference between string and String in C#
//// string is an alias for System.String. They are the same thing. You can use either

//string str1 = String.Concat("Hello", " ", "World");

//string str2 = "DotNet";
//str2 = "Ruby on Rails"; // string is immutable, so this creates a new string object and assigns it to str2


//// Proves that string is immutable in C#
//using System.Diagnostics;

//string str3 = "";
//var stopWatch = new Stopwatch();
//Console.WriteLine("New String replacement Loop Started");

//stopWatch.Start();
//for(int i = 0; i<30000000; i++)
//{
//    str3 = Guid.NewGuid().ToString(); // generates a new unique string every time and assign it to new memory location. This creates a new string object every time and assigns it to str3.
//}

//stopWatch.Stop();
//Console.WriteLine("New String replacement Loop Ended");
//Console.WriteLine("New String replacement Loop Execution Time: " + stopWatch.ElapsedMilliseconds + " ms");

//// when the value is same at the memory location, the same string object is used and no new string object is created. This is called string interning in C#.
//// Here replacement takes less time because the same string object is used and no new string object is created. This is called string interning in C#.
//var stopWatch1 = new Stopwatch();
//Console.WriteLine("Same String replacement Loop Started");
//stopWatch1.Start();
//str3 = "";
//for (int i = 0; i < 30000000; i++)
//{
//    str3 = "DotNet Tutorials"; // assigns the same string every time
//}

//stopWatch1.Stop();
//Console.WriteLine("Same String replacement Loop Ended");
//Console.WriteLine("Same String replacement Loop Execution Time: " + stopWatch1.ElapsedMilliseconds + " ms");


// string concatenation in C#
// using String Class
using System.Diagnostics;
using System.Text;

string str4 = "";
var stopWatch = new Stopwatch();
Console.WriteLine("Loop Started");

stopWatch.Start();
for(int i = 0; i < 300000; i++)
{
    str4 = String.Concat(str4, "DotNet Tutorials"); // creates a new string object every time and assigns it to str4.
}

stopWatch.Stop();
Console.WriteLine("Loop Ended");
Console.WriteLine("Loop Execution Time: " + stopWatch.ElapsedMilliseconds + " ms");

// using StringBuilder Class
StringBuilder stringBuilder = new StringBuilder();
var stopWatch1 = new Stopwatch();

stopWatch1.Start();
for(int i = 0; i < 300000; i++)
{
    stringBuilder.Append("DotNet Tutorials"); // appends the string to the existing string object and does not create a new string object.
}
stopWatch1.Stop();
Console.WriteLine("StringBuilder Loop Ended");
Console.WriteLine("StringBuilder Loop Execution Time: " + stopWatch1.ElapsedMilliseconds + " ms");
