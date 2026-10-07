Console.WriteLine(int.MaxValue);

int a = 2147483647;
int b = 2147483647;

//int c = checked(a + b); // here checked keyword throws an runtime error while overflowed the data.
                        // Checked keyword throws an exception by checking the overflow for integral type arithmetic operations and conversions
//Console.WriteLine(c);

const int p = 2147483647;
const int q = 2147483647;

//int r = p + q; // here for applying const keyword compiler produces error . 

int r = unchecked(p + q); // here unchecked bypass the error
Console.WriteLine(r);