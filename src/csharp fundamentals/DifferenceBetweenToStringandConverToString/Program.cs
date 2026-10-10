using DifferenceBetweenToStringandConverToString;

Customer c1 = new Customer();
c1 = null;

//Console.WriteLine(c1.ToString());
Console.WriteLine(Convert.ToString(c1));

String Name = null;
//Console.WriteLine(Name.ToString());
Console.WriteLine(Convert.ToString(Name));

// difference between ToString() and Convert.ToString() is Convert.ToString() handles null value and doesn't throw any exception
