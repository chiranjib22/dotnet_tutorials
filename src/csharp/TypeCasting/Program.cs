
int a;
// a = "Hello"; // Error: Cannot implicitly convert type 'string' to 'int'

// two types of type casting in C#:
// 1. Implicit Casting (Automatic)
// 2. Explicit Casting (Manual)

// Implicit Casting (Automatic) - done by the compiler when there is no risk of data loss

// condition 1 : must be compatible types. Ex: numeric types (int, long, float, double), char to int, etc.
// condition 2 : the destination type must be larger than the source type. Ex: int to long, float to double

int numInt = 1500;

Type numIntType = numInt.GetType();

double numDouble = numInt; // Implicit casting from int to double

Type numDoubleType = numDouble.GetType();

// value before conversion
Console.WriteLine($"numInt value: {numInt}");
Console.WriteLine($"numInt type: {numIntType}");
Console.WriteLine($"Int Size : {sizeof(int)} Byte");

// value after conversion
Console.WriteLine($"numDouble value: {numDouble}");
Console.WriteLine($"numDouble type: {numDoubleType}");
Console.WriteLine($"Double Size : {sizeof(double)} Byte");

// Explicit Casting (Manual) - done by the programmer when there is a risk of data loss
// if the destination type is smaller than the source type, but the types must be compatiable, then we need to use explicit casting


double num2Double = 1.23;

int num2Int = (int)num2Double; // Explicit casting from double to int

//value before conversion
Console.WriteLine($"num2Double value: {num2Double}");

//value after conversion
Console.WriteLine($"num2Int value: {num2Int}");

// Data loss dependes on the value of source and the destination type.
int num3Int = 500;
byte num3Byte = (byte)num3Int; 




// Using Convert Class for type conversion
// When the types are not compatiable but value must be convertable
string  strNum = "123";
int num4Int = Convert.ToInt32(strNum); // Convert string to int

double num5Double = 123.45;
int num5Int = Convert.ToInt32(num5Double);

float num6Float = 3.14f;
string str6String = Convert.ToString(num6Float);

Console.WriteLine($"Original Value for strNum: {strNum} and converted value for num4Int: {num4Int}");
Console.WriteLine($"Original Value for num5Double: {num5Double} and converted value for num5Int: {num5Int}");
Console.WriteLine($"Original Value for num6Float: {num6Float} and converted value for str6String: {str6String}");

// Convert class helper method throws error when the value is not compatiable with the destination type.
string sampleString = "Hello";
try
{ 
    int sampleInt = Convert.ToInt32(sampleString); // This will throw a FormatException because "Hello" cannot be converted to an integer.
}catch(Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}


// build in types in C# have built-in methods for type conversion, such as Parse and TryParse methods.
// Parse Method for type conversion
string strNum2 = "456";
int num7Int = int.Parse(strNum2); // Parse method implemented with build-in types.
Console.WriteLine($"Original String Value: {strNum2} and converted int value: {num7Int}");

string strBool = "TRUE";
bool boolValue = bool.Parse(strBool); // Parse method implemented with build-in types.
Console.WriteLine($"Original String Value: {strBool} and converted bool value: {boolValue}");

string strNum3 = "abc";
try
{
int num8Int = int.Parse(strNum3);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}

// TryParse method for type conversion
string strNum4 = "789";
bool isConverted = int.TryParse(strNum4, out int num9Int); // TryParse method implemented with build-in types.
if (isConverted)
{
    Console.WriteLine($"Original String Value: {strNum4} and converted int value: {num9Int}");
}
else
{
    Console.WriteLine($"Failed to convert '{strNum4}' to an integer.");
}

string strNum5 = "xyz";
bool isConverted2 = int.TryParse(strNum5, out int num10Int);
if (isConverted2)
{
    Console.WriteLine($"Original String value: {strNum5} and Converted int: {num10Int}");
}
else
{
    Console.WriteLine($"Failed to convert '{strNum5}' to an integer.");
}



