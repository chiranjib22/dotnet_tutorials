// Equals() is used to determine whether the specified parameter object is equal to the current object.

//using OverridingEquals;

// int number1 = 10;
// int number2 = 10;

// Console.WriteLine($"number1 == number2: { number1 == number2}"); // here == operator checks the value
// Console.WriteLine($"number1.Equals(number2): {number1.Equals(number2)}"); // here Equals() method checks the value

//// Enum type

// Direction direction1 = Direction.East;
// Direction direction2 = Direction.East;

// Console.WriteLine(direction1 == direction2); // enums are value type , so here values are checked
// Console.WriteLine(direction1.Equals(direction2));

// Reference Object Type
//using OverridingEquals;

//Customer c1 = new Customer();
//c1.FirstName = "Chiranjib";
//c1.LastName = "Chakraborty";

////Customer c2 = c1; // here c2 pointing the same customer object
//Customer c2 = new Customer();
//c2.FirstName = "Chiranjib";
//c2.LastName = "Chakraborty";

//Console.WriteLine($"c1 == c2 :{c1 == c2}"); // here comparing the memory address of the object not the value stored in
//Console.WriteLine($"c1.Equals(c2) : {c1.Equals(c2)}"); // here comparing the memory address of the object not the value stored in

// Override the equals object if we need to check the value stored at the object
//Customer c2 = c1; // here c2 pointing the same customer object
using OverridingEquals;

Customer c1 = new Customer();
Customer c2 = new Customer();
c2.FirstName = "Chiranjib";
c2.LastName = "Chakraborty";

Console.WriteLine($"c1 == c2 :{c1 == c2}"); // here comparing the memory address of the object not the value stored in
Console.WriteLine($"c1.Equals(c2) : {c1.Equals(c2)}"); // here comparing the memory address of the object not the value stored in





