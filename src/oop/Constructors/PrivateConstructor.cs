using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class PrivateConstructor
    {
        private PrivateConstructor() // use to implement singleton design pattern
        {
            Console.WriteLine("Private constructor called!");
        }

        public PrivateConstructor ObjectCreation()
        {
            return new PrivateConstructor();
        }
    }
}
