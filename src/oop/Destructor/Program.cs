using Destructor;

public class Program
{
    public static void ObjectCreation()
    {
        //DestructorDemo obj1 = new DestructorDemo();
        //DestructorDemo obj2 = new DestructorDemo();
        //Third obj = new Third();
        
    }
    public static void Main(string[] args)
    {
        UnmanagedResource resource = null;
        try
        {
            resource = new UnmanagedResource();
            Console.WriteLine("Using Resources");
        }
        finally
        {
            if(resource != null)
            {
                Console.WriteLine("Calling Dispose Method to Destroy Resources");
                resource.Dispose();
            }
        }

        // trying to call the Dispose()
        Console.WriteLine("Trying to call the Dispose method again to destroy resources");
        resource.Dispose();

        //ObjectCreation();
        //GC.Collect();
        //GC.WaitForPendingFinalizers();
        //GC.Collect();
    }
}

