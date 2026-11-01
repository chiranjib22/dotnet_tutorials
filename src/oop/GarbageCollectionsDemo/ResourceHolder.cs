using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionsDemo
{
    public class ResourceHolder : IDisposable
    {
        private bool _disposed = false;

        public ResourceHolder()
        {
            Console.WriteLine("Unmanaged resourced allocated.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool Disposing)
        {
            if(!_disposed)
            {
                if(Disposing)
                {
                    Console.WriteLine("Free other managed objects");
                }

                Console.WriteLine("Unmanaged resources released");
                _disposed = true;
            }
        }

        ~ResourceHolder()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called");
        }
    }
}
