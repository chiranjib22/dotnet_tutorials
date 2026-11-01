using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    // need a sealed class, which ensured that it cannot be inherited
    public sealed class SingletonPattern
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();

        // need a private static variable to hold reference the instance
        private static SingletonPattern instance = null;

        // need a static method which return the instance
        public static SingletonPattern GetSingletonInstance()
        {
            lock(Instancelock)
            {
                if(instance == null)
                {
                    instance = new SingletonPattern();
                }
                return instance;
            }
        }

        // need private and parameterless constructor
        private SingletonPattern()
        {
            counter++;
            Console.WriteLine($"Singleton constructor Executed {counter}");
        }

        public void SomeMethod(string message)
        {
            Console.WriteLine($"Some method called : {message}");
        }
    }
}
