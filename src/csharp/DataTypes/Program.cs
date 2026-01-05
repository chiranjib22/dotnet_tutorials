
// byte is unsigned 8-bit integer (0 to 255)
using System.Diagnostics;

byte b1 = 66;

Console.WriteLine($"Decimal: {b1}");
Console.WriteLine($"ASCII Character: {(char)b1}");
Console.WriteLine($"Byte Min Value: {byte.MinValue} and Max Value:{byte.MaxValue}");
Console.WriteLine($"Byte Size: {sizeof(byte)}");


// sbyte is signed 8-bit integer (-128 to 127)
sbyte sb1 = -66;

Console.WriteLine($"Decimal: {sb1}");
Console.WriteLine($"ASCII Character: {(char)sb1}");
Console.WriteLine($"Byte Min Value: {sbyte.MinValue} and Max Value:{sbyte.MaxValue}");
Console.WriteLine($"Byte Size: {sizeof(sbyte)}");


// char is unsigned 16-bit integer (0 to 65535)

char ch = 'B';
Console.WriteLine($"Char: {ch}");
Console.WriteLine($"Equivalent Number: {(byte)ch}");
Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
Console.WriteLine($"Char Size: {sizeof(char)}");

// string is a sequence of characters

string str = "ABC";
var howManyBytes = str.Length * sizeof(char);
Console.WriteLine($"String: {str}");
Console.WriteLine($"String Length: {str.Length}");

// Integer types: Int16, Int32, Int64

Int16 num1 = 123;
Int32 num2 = 456;
Int64 num3 = 789;

Console.WriteLine($"Int16 Min Value:{Int16.MinValue} and Max Value: {Int16.MaxValue}");
Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");
Console.WriteLine($"Int32 Min Value:{Int32.MinValue} and Max Value: {Int32.MaxValue}");
Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");
Console.WriteLine($"Int64 Min Value:{Int64.MinValue} and Max Value: {Int64.MaxValue}");
Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");

// same as above using short, int, long
short num4 = 123;
int num5 = 456;
long num6 = 789;

Console.WriteLine($"short Min Value:{short.MinValue} and Max Value: {short.MaxValue}");
Console.WriteLine($"short Size:{sizeof(short)} Byte");
Console.WriteLine($"int Min Value:{int.MinValue} and Max Value: {int.MaxValue}");
Console.WriteLine($"int Size:{sizeof(int)} Byte");
Console.WriteLine($"long Min Value:{long.MinValue} and Max Value: {long.MaxValue}");
Console.WriteLine($"long Size:{sizeof(long)} Byte");

ushort num7 = 123;
uint num8 = 456;
ulong num9 = 789;

Console.WriteLine($"ushort Min Value:{ushort.MinValue} and Max Value: {ushort.MaxValue}");
Console.WriteLine($"ushort Size:{sizeof(ushort)} Byte");
Console.WriteLine($"uint Min Value:{uint.MinValue} and Max Value: {uint.MaxValue}");
Console.WriteLine($"uint Size:{sizeof(uint)} Byte");
Console.WriteLine($"ulong Min Value:{ulong.MinValue} and Max Value: {ulong.MaxValue}");
Console.WriteLine($"ulong Size:{sizeof(ulong)} Byte");


// Floating point types: Single, Double, Decimal

Single a = 12.34f;
Double b = 12.34;
Decimal c = 12.34m;

Console.WriteLine($"Single Min Value:{Single.MinValue} and Max Value: {Single.MaxValue}");
Console.WriteLine($"Single Size:{sizeof(Single)} Byte");

Console.WriteLine($"Double Min Value:{Double.MinValue} and Max Value: {Double.MaxValue}");
Console.WriteLine($"Double Size:{sizeof(Double)} Byte");

Console.WriteLine($"Decimal Min Value:{Decimal.MinValue} and Max Value: {Decimal.MaxValue}");
Console.WriteLine($"Decimal Size:{sizeof(Decimal)} Byte");

// float, double, decimal are aliases for Single, Double, Decimal

float a2 = 12.34f;
double b2 = 12.34;
decimal c2 = 12.34m;

Console.WriteLine($"float Min Value:{float.MinValue} and Max Value: {float.MaxValue}");
Console.WriteLine($"float Size:{sizeof(float)} Byte");
Console.WriteLine($"double Min Value:{double.MinValue} and Max Value: {double.MaxValue}");
Console.WriteLine($"double Size:{sizeof(double)} Byte");
Console.WriteLine($"decimal Min Value:{decimal.MinValue} and Max Value: {decimal.MaxValue}");
Console.WriteLine($"decimal Size:{sizeof(decimal)} Byte");

// digit precision and range

float a3 = 1.23456789012345678908768767678676768787768f;
double b3 = 1.2222222222222222222222222222222222222222;
decimal c3 = 1.333333333333333333333333333333333333333m;

Console.WriteLine($"float value: {a3}");    // 7 digits precision
Console.WriteLine($"double value: {b3}");   // 15-16 digits precision
Console.WriteLine($"decimal value: {c3}");  // 28-29 digits precision


// data types performance test
Stopwatch stopwatch1 = new Stopwatch();
stopwatch1.Start();

for(int i = 0; i <= 1000000; i++)
{
    short s1 = 100;
    short s2 = 100;
    short s3 = 100;
}

stopwatch1.Stop();
Console.WriteLine($"Time taken for short: {stopwatch1.ElapsedMilliseconds} ms");

Stopwatch stopwatch2 = new Stopwatch();
stopwatch2.Start();

for (int i = 0; i <= 1000000; i++)
{
    decimal s1 = 100;
    decimal s2 = 100;
    decimal s3 = 100;
}

stopwatch2.Stop();
Console.WriteLine($"Time taken for decimal: {stopwatch2.ElapsedMilliseconds} ms");

// Default values of data types

Console.WriteLine($"Default value of byte: {default(byte)}");
Console.WriteLine($"Default value of Integer: {default(int)}");
Console.WriteLine($"Default value of Float: {default(float)}");
Console.WriteLine($"Default value of Long: {default(long)}");
Console.WriteLine($"Default value of Double: {default(double)}");
Console.WriteLine($"Default value of Character: {default(char)}");
Console.WriteLine($"Default value of Boolean: {default(bool)}");

// pointer variable
unsafe
{
    int number = 10;
    int* ptr = &number;
    Console.WriteLine($"Value of number using pointer: {*ptr}");
    Console.WriteLine($"Address of number using pointer: {(int)ptr}");
}

