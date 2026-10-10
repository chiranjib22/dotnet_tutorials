
// integer Literals (Decimal, Hexadecimal, Binary) used as a value of byte,int,short,long
int a = 101; // Decimal literal
int b = 0x65; // Hexadecimal literal
int c = 0b01100101; // Binary literal

Console.WriteLine($"Decimal: {a}, Hexadecimal: {b}, Binary: {c}");

int d = 1000; //Integer literal
uint e = 1000U; // Unsigned integer literal
long f = 1000L; // Long integer literal
ulong g = 1000UL; // Unsigned long integer literal

Console.WriteLine($"Int: {d}, UInt: {e}, Long: {f}, ULong: {g}");


// floating-point Literals (Single, Double, Decimal) used as a value of float,double,decimal

double h = 12.34; // by default, a floating-point literal is treated as double
float i = 12.34F; // Suffix F indicates a float literal
double k = 12.34D; // Suffix D indicates a double literal. not required
decimal j = 12.34M; // Suffix M indicates a decimal literal

Console.WriteLine($"Float: {i}, Double: {k}, Decimal: {j}");

// character literal used as a value of char
char ch1 = 'A'; // plain character literal
char ch2 = '\u0041'; // Unicode character literal
char ch3 = '\n'; // escape sequence for newline

Console.WriteLine($"Char1: {ch1}, Char2: {ch2}, Char3: {ch3}(newline below)");

// string literal used as a value of string

string str1 = "Hello, World!"; // plain string literal
string str2 = "Line1" +
    "Line2"; // string literal with escape sequence

string str3 = @"C:\Users
                \Name\Documents"; // verbatim string literal print same as the input

Console.WriteLine($"Str1: {str1}");
Console.WriteLine($"Str2: {str2}");
Console.WriteLine($"Str4: {str3}");

// boolean literal used as a value of bool
bool bool1 = true; // always in lowercase
bool bool2 = false;


Console.WriteLine($"Bool1: {bool1}, Bool2: {bool2}");


// binary literal
int num1 = 0b1010; // binary literal for decimal 10
int num2 = 0b01000011; // binary literal for decimal 15

Console.WriteLine($"Num1:{num1}");
Console.WriteLine($"Char of num2: {Convert.ToChar(num2)}");
