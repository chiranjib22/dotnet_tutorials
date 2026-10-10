// all types directly and indirectly inherited the object class
using OverridingToString;

int Number = 100;
Console.WriteLine(Number.ToString());

Employee emp = new Employee();
emp.FirstName = "Chiranjib";
emp.LastName = "Chakraborty";

Console.WriteLine(emp.ToString());