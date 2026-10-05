// in order to encapsulate and protect the data members (fields or variables) the properties use
// Properties is a member of a class acts as an interface or medium to transfer the data
// Properties are special methods called accessors that are used to read, write or compute the values of private fields

// Assessors are special methods which are used to set and get the values from the underlying data members.

// set accessor is used to set the data field. Value is a keyword which is used to assign the value to the data member.
// The set accessor is called when the property is assigned a value.

// get accessor is used to get the value of the data field.
// The get accessor is called when the property is read.

//using Properties;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee employee = new Employee();
//        employee.EmpId = 101; // using set accessor to set the values of private data members
//        employee.EmpName = "John Doe"; // using set accessor to set the values of private data members

//        Console.WriteLine("Employee ID: " + employee.EmpId);
//        Console.WriteLine("Employee Name: " + employee.EmpName);
//    }

//}

// There are 4 types of properties in C#
// 1. Read-only properties
// 2. Write-only properties
// 3. Read-write properties
// 4. Auto-implemented properties

//using Properties;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Console.WriteLine("Enter two numbers:");
//        calculator.SetNum1 = int.Parse(Console.ReadLine()!);
//        calculator.SetNum2 = int.Parse(Console.ReadLine()!);

//        calculator.Add();
//        Console.WriteLine($"This sum is: {calculator.GetResult}");

//        calculator.Sub();
//        Console.WriteLine($"This difference is: {calculator.GetResult}");

//        calculator.Mul();
//        Console.WriteLine($"This product is: {calculator.GetResult}");

//        calculator.Div();
//        Console.WriteLine($"This Div is: {calculator.GetResult}");
//        Console.ReadLine();
//    }
//}

using Properties;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Developer developer = new Developer();
//        developer.Id = 1;
//        developer.Age = 30;
//        developer.Name = "John Doe";
//        developer.Skill = "C#";
//        Console.WriteLine($"Developer ID: {developer.Id}");
//        Console.WriteLine($"Developer Age: {developer.Age}");
//        Console.WriteLine($"Developer Name: {developer.Name}");
//        Console.WriteLine($"Developer Skill: {developer.Skill}");
//    }
//}

// example using getter and setter method

//public class Program
//{
//    private int _Id;
//    private string? _Name;
//    private int _PassMark = 35;

//    public void SetId(int id)
//    {
//        if (id < 0) throw new Exception("Id value should be greater that 0");
//        _Id = id;
//    }

//    public int GetId()
//    {
//        return _Id;
//    }

//    public void SetName(string name)
//    {
//        if(string.IsNullOrEmpty(name)) throw new Exception("Name cannot be null or empty");
//        _Name = name;
//    }

//    public string GetName()
//    {
//        if (string.IsNullOrEmpty(_Name)) return "No Name";
//        return _Name;
//    }

//    static void Main(string[] args)
//    {
//        Program program = new Program();
//        program.SetId(1);
//        program.SetName("John Doe");
//        Console.WriteLine($"Id: {program.GetId()}");
//        Console.WriteLine($"Name: {program.GetName()}");
//    }
//}

// same example using properties

public class Program
{
    private int _Id;
    private string? _Name;
    private int _PassMark = 35;
    public int Id
    {
        get { return _Id; }
        set
        {
            if (value < 0) throw new Exception("Id value should be greater than 0");
            _Id = value;
        }
    }
    public string Name
    {
        get { return _Name ?? "No Name"; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception("Name cannot be null or empty");
            _Name = value;
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Id = 1;
        program.Name = "John Doe";
        Console.WriteLine($"Id: {program.Id}");
        Console.WriteLine($"Name: {program.Name}");
    }
}

