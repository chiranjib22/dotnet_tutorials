// in .NET primitive types or Reference types are called by value is the default behaviour

//int a = 15;
//int b = a;
//b = 30;
//Console.WriteLine(a); // the value of a has copied to the b

using CallByValueOrReference;

// call by value with value type
static void UpdateValue(int b) // updateValue() can not change the value of actual parameter d
{
    b = 30;
}

int d = 15;
UpdateValue(d);
Console.WriteLine(d);


Employee emp1 = new Employee();
emp1.EmployeeID = 1001;
emp1.Name = "James";

Employee emp2 = new Employee();
emp2 = emp1; // here emp2 store the value of emp1 which is a memory address of the Employee object 
emp2.Name = "Smith";

Console.WriteLine($"Emp1 Name = {emp1.Name}");
Console.WriteLine($"Emp2 Name = {emp2.Name}");


// call by value with reference type
static void UpdateName(Employee emp)
{
    emp.Name = "Jack"; // here we can't change the actual parameter value.. we just can the value of the object which address is held by the actual parameter
}
UpdateName(emp2);
Console.WriteLine($"Emp1 Name = {emp1.Name}");
Console.WriteLine($"Emp2 Name = {emp2.Name}");

static void UpdateName2(Employee emp)
{
    emp = null; // here emp variable is storing null instead of employee object reference. But it doesn't effect the actual parameter emp2. emp2 is holding the object reference
}
UpdateName2(emp2);
Console.WriteLine($"Emp1 Name = {emp1.Name}");
Console.WriteLine($"Emp2 Name = {emp2.Name}");


// call by reference with Value Types

static void UpdateValue2(ref int b) // but here UpdateValue2() can change the actual parameter value
{
    b = 30;
}

int e = 10;
UpdateValue(e); // UpdateValue() can't change the value of the actual parameter e. 
Console.WriteLine(e);
UpdateValue2(ref e);
Console.WriteLine(e);

static void UpdateName3( ref Employee emp) // here UpdateName3() can change the value of actual parameter
{
    emp = null;
}
UpdateName3(ref emp2);
Console.WriteLine($"Emp1 Name = {emp1.Name}"); // emp1 is holding the object reference
Console.WriteLine($"Emp2 Name = {emp2.Name}"); // here null exception thrown because emp2 is holding now null and its value is originally changed

// difference between Call by Value and Call by Reference

// Call by Value : Can not change the Actual Parameter value, affect only formal Parameter
// Call By Reference : Can affect both formal and actual parameter


