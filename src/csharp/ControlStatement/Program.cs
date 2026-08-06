// By Default program statement are excuted sequentially line by line from TOP to BOTTOM of the solution file

//Console.WriteLine("Executing Statment1");
//Console.WriteLine("Executing Statment2");
//Console.WriteLine("Executing Statment3");
//Console.WriteLine("Executing Statment4");
//Console.WriteLine("Executing Statment5");

// we can skip the excution of some statement based on condition 

//if(10 > 5)
//{
//    Console.WriteLine("Executing Statment1");
//    Console.WriteLine("Executing Statment2");
//}else
//{
//    Console.WriteLine("Executing Statment3");
//    Console.WriteLine("Executing Statment4");
//}
//Console.WriteLine("Executing Statment5");

// we can repeatedly execute some statement 

//for(int i = 0; i<5; i++)
//{
//    Console.WriteLine("Welcome to C#.NET");
//}
//Console.WriteLine("Some Other Statement");

// we can jump to any statement bellow or top 

Console.WriteLine("Executing Statment1");
goto STATEMENT4;
Console.WriteLine("Executing Statment2");

//STATEMENT3:
Console.WriteLine("Executing Statment3");

STATEMENT4:     // label
Console.WriteLine("Executing Statment4");
//goto STATEMENT3;

// Control Statement are 4 types
// 1. Selection Statement or Branching Statement. if..else, switch
// 2. Iteration Statement or Looping Statement. while, do while, for, foreach
// 3. Jumping Statement. goto, break, continue, return
