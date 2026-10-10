// switch statement is a multiway branch statement and supports integral, string and enum types expressions or values

//int a = 2;
//switch(a)
//{
//    case 0: 
//        Console.WriteLine("a is 0");
//        break;
//    case 1:
//        Console.WriteLine("a is 1");
//        break;
//    case 2:
//        Console.WriteLine("a is 2");
//        break;
//    default:
//        Console.WriteLine("a is not 0, 1 or 2");
//        break;
//}


// switch statement support multiple case labels for a single statement block, and
// it also supports fall through behaviour, which means that if a case label does not have a break statement,
// the control will fall through to the next case label until it finds a break statement or reaches the end of the switch statement.
//string str = "C#";
//switch(str)
//{
//    case "C#":
//    case "Java":
//    case "Python":
//        Console.WriteLine("It is a programming language"); // here all case labels are working as OR operator.
//        break;
//    case "MSSQL":
//    case "MySQL":
//    case "Oracle":
//        Console.WriteLine("It is a database");
//        break;
//    case "MVC":
//    case "WebAPI":
//        Console.WriteLine("It is a framework");
//        break;
//    default:
//        Console.WriteLine("Invalid Input");
//        break;
//}

// nested switch statement
int number = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

switch(number)
{
    case 1:
        Console.WriteLine("You Entered One");
        Console.WriteLine("Enter Color Code (RGB): ");
        char color = Convert.ToChar(Console.ReadLine()!);

        switch(Char.ToUpper(color))
        {
            case 'R':
                Console.WriteLine("Red Color");
                break;
            case 'G':
                Console.WriteLine("Green Color");
                break;
            case 'B':
                Console.WriteLine("Blue Color");
                break;
            default:
                Console.WriteLine("Invalid Color Code");
                break;
        }
        break;
    case 2:
        Console.WriteLine("You Entered Two");
        break;
    case 3:
        Console.WriteLine("You Entered Three");
        break;
    default:
        Console.WriteLine("Invalid Number");
        break;
}
// switch statement only works with:
// Primitive types: int, long, short, byte, char, bool
// Enumerated types : (Enum)
// String Class
// Nullable Types of the above type
