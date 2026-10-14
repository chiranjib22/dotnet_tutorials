using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class StaticConstructor
    {
        int i;
        static int j;
        static StaticConstructor() // always called implicitly
        {
            // can be only one per class
            // no access specifier used
            // static constructor cannot be parameterized, overloading is not possible
            // can access only static members
            //i = 0;
            j = 10;
            // can be invoked only once
            Console.WriteLine("Static constructor called!");
        }

        public StaticConstructor()
        {
            i = 0; // we can access static member with non-static constructor
            j = 20;
            Console.WriteLine("Instance constructor is called!");
        }
        public static void Display()
        {
            Console.WriteLine("Display method called!");
        }
    }
}
