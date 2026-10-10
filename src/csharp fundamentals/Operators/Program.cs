public class Program
{
    static void Main(String[] args)
    {
        int result;
        int num1 = 20, num2 = 10;

        // Arithmetic Operators
        // Addition
        result = num1 + num2;
        Console.WriteLine($"Addition: {num1} + {num2} = {result}");

        // Subtraction
        result = num1 - num2;
        Console.WriteLine($"Subtraction:{num1} - {num2} = {result}");

        // Multiplication
        result = num1 * num2;
        Console.WriteLine($"Multiplication: {num1} * {num2} = {result}");

        // Division
        result = num1 / num2;
        Console.WriteLine($"Division: {num1} / {num2} = {result}");

        // Modulus
        result = num1 % num2;
        Console.WriteLine($"Modulus: {num1} % {num2} = {result}");

        // Assignment Operators
        // Add Assignment
        num1 += num2;
        Console.WriteLine($"Add Assignment: num1 += num2 => num1 = {num1}");

        // Subtract Assignment
        num1 -= num2;
        Console.WriteLine($"Subtract Assignment: num1 -= num2 => num1 = {num1}");

        // Multiply Assignment
        num1 *= num2;
        Console.WriteLine($"Multiply Assignment: num1 *= num2 => num1 = {num1}");

        // Divide Assignment
        num1 /= num2;
        Console.WriteLine($"Divide Assignment: num1 /= num2 => num1 = {num1}");

        // Modulus Assignment
        num1 %= num2;
        Console.WriteLine($"Modulus Assignment: num1 %= num2 => num1 = {num1}");

        // Relational Operators or Comparison Operators
        // Equal to
        bool r = (num1 == num2);
        Console.WriteLine($"Equal to: {num1} == {num2} => {r}");

        // Not Equal to
        r = (num1 != num2);
        Console.WriteLine($"Not Equal to: {num1} != {num2} => {r}");

        // Greater than
        r = (num1 > num2);
        Console.WriteLine($"Greater than: {num1} > {num2} => {r}");

        // Less than
        r = (num1 < num2);
        Console.WriteLine($"Less than: {num1} < {num2} => {r}");

        // Greater than or Equal to
        r = (num1 >= num2);
        Console.WriteLine($"Greater than or Equal to: {num1} >= {num2} => {r}");

        // Less than or Equal to
        r = (num1 <= num2);
        Console.WriteLine($"Less than or Equal to: {num1} <= {num2} => {r}");

        // Logical Operators
        bool x = true;
        bool y = false;

        // Logical OR
        r = x || y;
        Console.WriteLine($"Logical OR operator (||) : {r}");

        // Logical AND
        r = x && y;
        Console.WriteLine($"Logical AND operator (&&) : {r}");

        // Logical NOT
        r = !x;
        Console.WriteLine($"Logical NOT operator (!) : {r}");

        // Bitwise Operator
        // Bitwise OR 
        result = num1 | num2;
        Console.WriteLine($"Bitwise OR of {num1} and {num2} : {result}");

        // Bitwise AND 
        result = num1 & num2;
        Console.WriteLine($"Bitwise AND of {num1} and {num2} : {result}");

        // Bitwise XOR 
        result = num1 ^ num2;
        Console.WriteLine($"Bitwise XOR of {num1} and {num2} : {result}");

        // if operands are boolean type then bitwise operator behaves like logical operator

        // Bitwise OR 
        r = x | y;
        Console.WriteLine($"Bitwise OR of {x} and {y} : {r}");

        // Bitwise AND 
        r = x & y;
        Console.WriteLine($"Bitwise AND of {x} and {y} : {r}");

        // Bitwise XOR 
        r = x ^ y;
        Console.WriteLine($"Bitwise XOR of {x} and {y} : {r}");


        // unary operators
        // Complex Expression Evalution Algorithm :
        // 1. Pre Increament or Pre Decrement
        // 2. Substitute the value
        // 3. Evaluation of the expression
        // 4. Assignment the result
        // 5. Post Increamnt or Post Decrement

        int p = 10;
        int q = 20;
        int o = p++ * --q;
        Console.WriteLine($"p = {p} q = {q} and o = {o}");


        // Ternary Operators
        result = num1 > num2 ? 1 : 0;
        Console.WriteLine($"result = {result}");

    }
}