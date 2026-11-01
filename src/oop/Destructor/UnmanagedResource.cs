using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class UnmanagedResource : IDisposable
    {
        private bool disposedValue = false; // indentify the redundent call
        protected virtual void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if(disposing)
                {
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }
                Console.WriteLine("Free unmanaged resources and orride a finalizer below");
                //Console.WriteLine("set large fields to null");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are already destroyed");
            }
        }

        ~UnmanagedResource()
        {
            Console.WriteLine("Request comes to destructor to destroy the resources");
            Dispose(false);
        }

        public void Dispose()
        {
            Console.WriteLine("Request comes to dispose method to destroyed the resources");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
