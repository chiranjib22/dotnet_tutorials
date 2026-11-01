// Modifiers are : public, private, protected, internal, virtual, sealed, partial, abstract, static, base etc
// Access Specifiers are special type of modifiers which are used to control the accessibility
// or scope of type and its types memeber.

// there are 6 types of access specifiers in C#
// 1. Public
// 2. Private
// 3. Protected
// 4. Internal
// 5. Protected Internal
// 6. Private Protected

// for types by default access specifier is internal and for members it is private

// Scope of type members are
// 1. Within the class                        : private, public, protected, internal, Protected Internal, Private Protected 
// 2. Derived class int the same assembly     :    x   , public, protected, internal, Protected Internal, Private Protected
// 3. Non-derived class in same assembly      :    x   , public,     x    , internal, Protected Internal,       x
// 4. Derived class in different assembly     :    x   , public, protected,     x   , Protected Internal,       x
// 5. Non-derived class in different assembly :    x   , public,     x    ,     x   ,     x             ,       x

using AssemblyOne;

public class Program
{
    static void Main(string[] args)
    {

    }
}

public class AnotherAssemblyClass1 : AssemblyOneClass1
{
    public void Display4()
    {
        //Console.WriteLine(Id); // private member cannot be accessed from the derived class in different assembly
        Console.WriteLine(publicId); // public member can be accessed from the derived class in different assembly
        Console.WriteLine(protectedId); // protected member can be accessed from the derived class in different assembly
        //Console.WriteLine(internalId); // internal member can be accessed from the derived class in different assembly
        Console.WriteLine(protectedInternalId); // protected internal member can be accessed from the derived class in different assembly
        //Console.WriteLine(privateProtectedId); // private protected member can not be accessed from the derived class in different assembly
    }
}

public class  AnotherAssemblyClass2
{
    public void Display5()
    {
        AssemblyOneClass1 obj = new AssemblyOneClass1();
        //Console.WriteLine(obj.Id); // private member cannot be accessed from the non-derived class in different assembly
        Console.WriteLine(obj.publicId); // public member can be accessed from the non-derived class in different assembly
        //Console.WriteLine(obj.protectedId); // protected member cannot be accessed from the non-derived class in different assembly
        //Console.WriteLine(obj.protectedInternalId); // protected internal member cannot be accessed from the non-derived class in different assembly
        //Console.WriteLine(obj.privateProtectedId); // private protected member can not be accessed from the non-derived class in different assembly
    }
}
