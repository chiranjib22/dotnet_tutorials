namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        private int Id;
        public int publicId;
        protected int protectedId;
        internal int internalId;
        protected internal int protectedInternalId;
        private protected int privateProtectedId;
        public void Display1()
        {
            Console.WriteLine(Id); // private member accessible within the containing type
            Console.WriteLine(publicId); // public member accessible within the containing type
            Console.WriteLine(protectedId); // protected member accessible within the containing type
            Console.WriteLine(internalId); // internal member accessible within the containing type
            Console.WriteLine(protectedInternalId); // protected internal member accessible within the containing type
            Console.WriteLine(privateProtectedId); // private protected member accessible within the containing type
        }
    }

    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void Display2()
        {
            //Console.WriteLine(Id); // private member cannot be accessed from the derived class within the same assembly
            Console.WriteLine(publicId); // public member can be accessed from the derived class within the same assembly
            Console.WriteLine(protectedId); // protected member can be accessed from the derived class within the same assembly
            Console.WriteLine(internalId); // internal member can be accessed from the derived class within the same assembly
            Console.WriteLine(protectedInternalId); // protected internal member can be accessed from the derived class within the same assembly
            Console.WriteLine(privateProtectedId); // private protected member can be accessed from the derived class within the same assembly
        }
    }

    public class AssemblyOneClass3
    {
        public void Display3()
        {
            AssemblyOneClass1 obj = new AssemblyOneClass1();
            //Console.WriteLine(obj.Id); // private member cannot be accessed from the non-derived class within the same assembly
            Console.WriteLine(obj.publicId); // public member can be accessed from the non-derived class within the same assembly
            //Console.WriteLine(obj.protectedId); // protected member cannot be accessed from the non-derived class within the same assembly
            Console.WriteLine(obj.internalId); // internal member can be accessed from the non-derived class within the same assembly
            Console.WriteLine(obj.protectedInternalId); // protected internal member can be accessed from the non-derived class within the same assembly
            //Console.WriteLine(obj.privateProtectedId); // private protected member cannot be accessed from the non-derived class within the same assembly
        }
    }
}
