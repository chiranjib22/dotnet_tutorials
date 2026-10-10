// See https://aka.ms/new-console-template for more information

namespace ConsoleClass
{
    public class ConsoleClass
    {
        static void Main(string[] args)
        {
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The sum is {number1 + number2}");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Understanding the Console";

            int keyValue = Console.Read();
            Console.WriteLine($"ASCII value of the key is {keyValue}");
            ConsoleKeyInfo keyValye2 = Console.ReadKey();
            Console.WriteLine((int)keyValye2.KeyChar);

            Console.Beep();
        }
    }
}