
// Recursion have two phase : 1) calling Phase 2) returning phase
//int x = 3;
//fun(3);

//static void fun(int x)
//{
//    if (x > 0)
//    {
//        fun(x - 1);
//        Console.WriteLine(x);
//    }
//}

// Factorial example

using Recursion;

int number = 5;
int result = Factorial.CalculateFactorial(number);
Console.WriteLine(result);

