//class Program
//{
//    static void Main(string[] args)
//    {
//        for(int i = 0; i <= 1000000; i++)
//        {
//            MyClass1 obj1 = new MyClass1();
//            //obj1.Dispose();
//            MyClass2 obj2 = new MyClass2();
//            //obj2.Dispose();
//            MyClass3 obj3 = new MyClass3();
//            //obj3.Dispose();
//        }
//    }
//}

//public class MyClass1 : IDisposable
//{
//    private bool disposedValue = false;
//    protected virtual void Dispose(bool disposing)
//    {
//        if(!disposedValue)
//        {
//            if(disposing)
//            {
//                // disposed managed object
//            }

//            // free unmanaged resources
//            disposedValue = true;
//        }
//    }
//    ~MyClass1()
//    {
//        Dispose(false);
//    }

//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }
//}
//public class MyClass2 : IDisposable
//{
//    private bool disposedValue = false;

//    protected virtual void Dispose(bool disposing)
//    {
//        if(!disposedValue)
//        {
//            if(disposing)
//            {

//            }
//            disposedValue = true;
//        }
//    }

//    ~MyClass2()
//    {
//        Dispose(false);
//    }

//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }
//}
//public class MyClass3
//{
//    private bool disposedValue = false;
//    protected virtual void Dispose(bool disposing)
//    {
//        if(!disposedValue)
//        {
//            if(disposing)
//            {

//            }
//            disposedValue = true;
//        }
//    }

//    ~MyClass3()
//    {
//        Dispose(false);
//    }

//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }
//}

using GarbageCollectionsDemo;

class Program
{
    static void Main(string[] args)
    {
        using(var resourceHolder = new ResourceHolder())
        {
            // use the resource..

        } // disposed is called auotmatically..


        var anotherResourceHolder = new ResourceHolder();
        // use the resource
        anotherResourceHolder.Dispose(); // without using dispose should be called manually

        var finalResourceHolder = new ResourceHolder();
        // use the resource
        // here finalizer called..

    }
}