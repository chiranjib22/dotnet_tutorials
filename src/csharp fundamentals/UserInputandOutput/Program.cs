
//// difference between Write() and WriteLine() methods
//Console.Write("Prints on");
//Console.WriteLine("New Line");

//Console.Write("Prints on");
//Console.WriteLine("Same Line");

//// printing varibales and literals
//int number = 10;
//Console.WriteLine(number);
//Console.WriteLine(50.55);

//Console.WriteLine("Hello" + "C#");
//Console.WriteLine("Number = " + number);

//// printing concatenated string 
//int number1 = 15;
//int number2 = 20;
//int sum = number1 + number2;
//Console.WriteLine("{0} + {1} = {2}", number1, number2, sum); // string formatting


//string str;
//Console.Write("Enter a string - ");
//str = Console.ReadLine(); // Waits for user input
//Console.WriteLine($"You entered: {str}"); // string interpolation


//// Difference between Read() and ReadKey() methods
//Console.WriteLine("Press any key to continue...");
//ConsoleKeyInfo keyInfo = Console.ReadKey(); // returns a ConsoleKeyInfo object that represents the key pressed by the user
//Console.WriteLine(keyInfo.GetType());
//Console.WriteLine(keyInfo);

//Console.Write("Input using Read() - ");
//var userInput = Console.Read(); // returns an integer value that represents the next character from the input stream
//Console.WriteLine(userInput.GetType());
//Console.WriteLine(userInput);

// input Numeric values from user
string usrInput;
int intValue;
double doubleValue;

Console.Write("Enter integer value: ");
usrInput = Console.ReadLine()!;
intValue = Convert.ToInt32(usrInput);
intValue = Convert.ToInt32(Console.ReadLine()!); // alternative way to read input and convert to int


Console.Write("Enter double value: ");
usrInput = Console.ReadLine()!;
doubleValue = Convert.ToDouble(usrInput);
doubleValue = Convert.ToDouble(Console.ReadLine()!); // alternative way to read input and convert to double


