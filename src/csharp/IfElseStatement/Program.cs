// selection of branching or decision-making statements

// if statement
//int number;
//number = int.Parse(Console.ReadLine()!);

//if (number > 10)
//    Console.WriteLine($"{number} is greater than 10");  // considered as single statement if block, no need to use {} for single statement
//Console.WriteLine("End of Main Method");

// if-else statement
//if(number > 10)
//    Console.WriteLine($"{number} is greater than 10");
//else
//    Console.WriteLine($"{number} is less than or equal to 10");
//Console.WriteLine("End of Main Method");

//int a = 15, b = 25, c = 10;
//int LargestNumber = 0;

//if (a > b)
//{
//    if (a > c)
//        LargestNumber = a;
//    else
//        LargestNumber = c;

//}
//else
//{
//    if (b > c)
//        LargestNumber = b;
//    else
//        LargestNumber = c;
//}
//Console.WriteLine($"Largest Number is: {LargestNumber}");

// using ternary operator

//Console.WriteLine((a > b) ? ((a > c) ? (a) : (c)) : ((b > c) ? (b) : (c)));

// if-else-if ladder statement
int i = 20;
if(i == 10)
{
    Console.WriteLine("i is 10");
}
else if (i == 20)
{
    Console.WriteLine("i is 20");
}
else if (i == 30)
{
    Console.WriteLine("i is 30");
}
else
{
    Console.WriteLine("i is not present");
}


