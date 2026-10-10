// Boxing -> converting value type to a reference type

using System.Diagnostics;

int x = 10;
Object y = x;
Console.WriteLine(y);

// UnBoxing -> converting reference type to value type
int z = (int) y;
Console.WriteLine(z);




// Implication the performance of UnBoxing

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i = 0; i <= 1000000; i++)
{
    UnBoxing(); // degrade the performance. Took more time
}
stopwatch.Stop();
Console.WriteLine($"UnBoxing took: {stopwatch.ElapsedMilliseconds} MS");

Stopwatch stopwatch2 = new Stopwatch();
stopwatch2.Start();

for (int i = 0; i <= 1000000; i++)
{
    WithoutunBoxing();
}
stopwatch2.Stop();
Console.WriteLine($"Without UnBoxing took: {stopwatch2.ElapsedMilliseconds} MS");


static void UnBoxing()
{
    object i = 100;
    int j = (int)i; // unboxing;
}

static void WithoutunBoxing()
{
    int i = 100;
    int j = i;
}

// it is recommended to avoid boxing and unboxing
// 1. Use generices
