// 4 types of user defined functions
// 1. No argument and no return type
// 2. Argument and no return type
// 3. No Argument and return type
// 4. Argument and return type

//// no argument and no return type
//static void Sum()
//{
//    int x = 10;
//    int y = 20;
//    int sum = x + y;
//    Console.WriteLine(sum);
//}
//Sum();

//// argument and no return type
//static void Sum2(int x, int y)
//{
//    int sum = x + y;
//    Console.WriteLine(sum);
//}
//Sum2(5, 10);

//// no argument and return type
//static int Sum3()
//{
//    int x = 10;
//    int y = 20;
//    int sum = x + y;
//    return sum;
//}
//Console.WriteLine(Sum3());

//// agrument and return type
//static int Sum4(int x, int y)
//{
//    int sum = x + y;
//    return sum;
//}

//Console.WriteLine(Sum4(10, 5));

// function overloading
class Program
{
    static int sum(int a, int b)
    {
        return a + b;
    }
    static int sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static float sum(float a, float b) {
        return a+b;
    }
    static void Main(string[] args)
    {
        int a = sum(1, 2);
        int b = sum(1, 2, 3);
        float c = sum(10, 5);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

// different parameter list means two different method with same name
// int add(int, int)
// int add(int , int, int)
// int add(float, float)
// float add(int, int) // invalid because here parameter list are same
// so different return type doesn't satisfy the function overloading condition

